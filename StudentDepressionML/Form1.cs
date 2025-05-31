using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Globalization;
using System.Text;

namespace StudentDepressionML
{
    public partial class Form1 : Form
    {
        #region Costanti e Configurazioni

        // Pesi per l'algoritmo di predizione
        private const double WEIGHT_ACADEMIC_PRESSURE = 0.15;
        private const double WEIGHT_WORK_PRESSURE = 0.12;
        private const double WEIGHT_FINANCIAL_STRESS = 0.13;
        private const double WEIGHT_CGPA = 0.10;
        private const double WEIGHT_STUDY_SATISFACTION = 0.08;
        private const double WEIGHT_JOB_SATISFACTION = 0.08;
        private const double WEIGHT_SLEEP = 0.12;
        private const double WEIGHT_FAMILY_HISTORY = 0.10;
        private const double WEIGHT_SUICIDAL_THOUGHTS = 0.12;

        // Soglie di rischio
        private const double LOW_RISK_THRESHOLD = 30.0;
        private const double MODERATE_RISK_THRESHOLD = 60.0;

        #endregion

        #region Costruttore e Inizializzazione

        public Form1()
        {
            InitializeComponent();
            InitializeComboBoxes();
            InitializeEventHandlers();
        }

        private void InitializeComboBoxes()
        {
            // Genere
            cmbGender.Items.AddRange(new string[] { "Maschio", "Femmina", "Altro", "Preferisco non rispondere" });

            // Professione
            cmbProfession.Items.AddRange(new string[] {
                "Studente", "Impiegato", "Libero Professionista", "Operaio",
                "Insegnante", "Medico", "Ingegnere", "Altro"
            });

            // Titolo di Studio
            cmbDegree.Items.AddRange(new string[] {
                "Scuola Media", "Diploma", "Laurea Triennale", "Laurea Magistrale",
                "Master", "Dottorato", "Altro"
            });

            // Durata Sonno
            cmbSleepDuration.Items.AddRange(new string[] {
                "Meno di 5 ore", "5-6 ore", "6-7 ore", "7-8 ore", "8-9 ore", "Più di 9 ore"
            });

            // Abitudini Alimentari
            cmbDietaryHabits.Items.AddRange(new string[] {
                "Molto Buone", "Buone", "Discrete", "Scarse", "Molto Scarse"
            });

            // Storia Familiare
            cmbFamilyHistory.Items.AddRange(new string[] { "Sì", "No", "Non so" });

            // Pensieri Suicidi
            cmbSuicidalThoughts.Items.AddRange(new string[] { "Mai", "Raramente", "A volte", "Spesso", "Sempre" });
        }

        private void InitializeEventHandlers()
        {
            // Associa il click del Reset che mancava nel Designer
            btnReset.Click += btnReset_Click;

            // Gestione Enter per avviare predizione
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
        }

        #endregion

        #region Eventi Principali

        private void btnPredict_Click(object sender, EventArgs e)
        {
            try
            {
                // Validazione input
                if (!ValidateInputs())
                    return;

                // Raccolta dati
                var inputData = CollectInputData();

                // Esecuzione predizione
                double riskPercentage = PredictDepression(inputData);

                // Aggiornamento interfaccia
                UpdateResults(riskPercentage);

                // Log del risultato (opzionale)
                LogPrediction(inputData, riskPercentage);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore durante l'analisi: {ex.Message}",
                    "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTestData_Click(object sender, EventArgs e)
        {
            try
            {
                PopulateTestData();
                MessageBox.Show("Dati di test caricati con successo!",
                    "Dati Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore nel caricamento dati test: {ex.Message}",
                    "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnPredict_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnTestData_Click(sender, e);
            }
        }

        #endregion

        #region Validazione Input

        private bool ValidateInputs()
        {
            StringBuilder errors = new StringBuilder();

            // Validazione Età
            if (!int.TryParse(txtAge.Text, out int age) || age < 16 || age > 100)
            {
                errors.AppendLine("• Età deve essere un numero tra 16 e 100");
            }

            // Validazione Genere
            if (cmbGender.SelectedIndex == -1)
            {
                errors.AppendLine("• Selezionare il genere");
            }

            // Validazione Città (opzionale ma se inserita deve essere valida)
            if (string.IsNullOrWhiteSpace(txtCity.Text))
            {
                errors.AppendLine("• Inserire la città");
            }

            // Validazione Professione
            if (cmbProfession.SelectedIndex == -1)
            {
                errors.AppendLine("• Selezionare la professione");
            }

            // Validazione Titolo di Studio
            if (cmbDegree.SelectedIndex == -1)
            {
                errors.AppendLine("• Selezionare il titolo di studio");
            }

            // Validazione CGPA
            if (!double.TryParse(txtCGPA.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out double cgpa) ||
                cgpa < 0 || cgpa > 10)
            {
                errors.AppendLine("• CGPA deve essere un numero tra 0 e 10");
            }

            // Validazione Pressione Accademica
            if (!int.TryParse(txtAcademicPressure.Text, out int academicPressure) ||
                academicPressure < 1 || academicPressure > 10)
            {
                errors.AppendLine("• Pressione Accademica deve essere tra 1 e 10");
            }

            // Validazione Pressione Lavorativa
            if (!int.TryParse(txtWorkPressure.Text, out int workPressure) ||
                workPressure < 1 || workPressure > 10)
            {
                errors.AppendLine("• Pressione Lavorativa deve essere tra 1 e 10");
            }

            // Validazione Ore Studio/Lavoro
            if (!int.TryParse(txtWorkStudyHours.Text, out int hours) || hours < 1 || hours > 24)
            {
                errors.AppendLine("• Ore Studio/Lavoro devono essere tra 1 e 24");
            }

            // Validazione Soddisfazione Studio
            if (!int.TryParse(txtStudySatisfaction.Text, out int studySatisfaction) ||
                studySatisfaction < 1 || studySatisfaction > 10)
            {
                errors.AppendLine("• Soddisfazione Studio deve essere tra 1 e 10");
            }

            // Validazione Soddisfazione Lavoro
            if (!int.TryParse(txtJobSatisfaction.Text, out int jobSatisfaction) ||
                jobSatisfaction < 1 || jobSatisfaction > 10)
            {
                errors.AppendLine("• Soddisfazione Lavoro deve essere tra 1 e 10");
            }

            // Validazione Stress Finanziario
            if (!int.TryParse(txtFinancialStress.Text, out int financialStress) ||
                financialStress < 1 || financialStress > 10)
            {
                errors.AppendLine("• Stress Finanziario deve essere tra 1 e 10");
            }

            // Validazione ComboBox obbligatorie
            if (cmbSleepDuration.SelectedIndex == -1)
            {
                errors.AppendLine("• Selezionare la durata del sonno");
            }

            if (cmbDietaryHabits.SelectedIndex == -1)
            {
                errors.AppendLine("• Selezionare le abitudini alimentari");
            }

            if (cmbFamilyHistory.SelectedIndex == -1)
            {
                errors.AppendLine("• Specificare la storia familiare");
            }

            if (cmbSuicidalThoughts.SelectedIndex == -1)
            {
                errors.AppendLine("• Specificare la frequenza dei pensieri suicidi");
            }

            // Mostra errori se presenti
            if (errors.Length > 0)
            {
                MessageBox.Show($"Correggere i seguenti errori:\n\n{errors.ToString()}",
                    "Errori di Validazione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        #endregion

        #region Raccolta Dati

        private InputData CollectInputData()
        {
            return new InputData
            {
                Age = int.Parse(txtAge.Text),
                Gender = cmbGender.SelectedItem.ToString(),
                City = txtCity.Text,
                Profession = cmbProfession.SelectedItem.ToString(),
                Degree = cmbDegree.SelectedItem.ToString(),
                CGPA = double.Parse(txtCGPA.Text, CultureInfo.InvariantCulture),
                AcademicPressure = int.Parse(txtAcademicPressure.Text),
                WorkPressure = int.Parse(txtWorkPressure.Text),
                WorkStudyHours = int.Parse(txtWorkStudyHours.Text),
                StudySatisfaction = int.Parse(txtStudySatisfaction.Text),
                JobSatisfaction = int.Parse(txtJobSatisfaction.Text),
                FinancialStress = int.Parse(txtFinancialStress.Text),
                SleepDuration = cmbSleepDuration.SelectedItem.ToString(),
                DietaryHabits = cmbDietaryHabits.SelectedItem.ToString(),
                FamilyHistory = cmbFamilyHistory.SelectedItem.ToString(),
                SuicidalThoughts = cmbSuicidalThoughts.SelectedItem.ToString()
            };
        }

        #endregion

        #region Algoritmo di Predizione

        private double PredictDepression(InputData data)
        {
            double riskScore = 0.0;

            // Fattore Pressione Accademica (1-10, più alto = più rischio)
            riskScore += (data.AcademicPressure / 10.0) * WEIGHT_ACADEMIC_PRESSURE * 100;

            // Fattore Pressione Lavorativa (1-10, più alto = più rischio)
            riskScore += (data.WorkPressure / 10.0) * WEIGHT_WORK_PRESSURE * 100;

            // Fattore Stress Finanziario (1-10, più alto = più rischio)
            riskScore += (data.FinancialStress / 10.0) * WEIGHT_FINANCIAL_STRESS * 100;

            // Fattore CGPA (0-10, più basso = più rischio)
            double cgpaRisk = (10.0 - data.CGPA) / 10.0;
            riskScore += cgpaRisk * WEIGHT_CGPA * 100;

            // Fattore Soddisfazione Studio (1-10, più basso = più rischio)
            double studyRisk = (11.0 - data.StudySatisfaction) / 10.0;
            riskScore += studyRisk * WEIGHT_STUDY_SATISFACTION * 100;

            // Fattore Soddisfazione Lavoro (1-10, più basso = più rischio)
            double jobRisk = (11.0 - data.JobSatisfaction) / 10.0;
            riskScore += jobRisk * WEIGHT_JOB_SATISFACTION * 100;

            // Fattore Sonno
            double sleepRisk = GetSleepRiskFactor(data.SleepDuration);
            riskScore += sleepRisk * WEIGHT_SLEEP * 100;

            // Fattore Storia Familiare
            double familyRisk = GetFamilyHistoryRiskFactor(data.FamilyHistory);
            riskScore += familyRisk * WEIGHT_FAMILY_HISTORY * 100;

            // Fattore Pensieri Suicidi (molto importante)
            double suicidalRisk = GetSuicidalThoughtsRiskFactor(data.SuicidalThoughts);
            riskScore += suicidalRisk * WEIGHT_SUICIDAL_THOUGHTS * 100;

            // Fattori aggiuntivi
            riskScore += GetAgeRiskFactor(data.Age) * 5;
            riskScore += GetDietaryRiskFactor(data.DietaryHabits) * 8;
            riskScore += GetWorkHoursRiskFactor(data.WorkStudyHours) * 7;

            // Assicurati che il punteggio sia tra 0 e 100
            return Math.Max(0, Math.Min(100, riskScore));
        }

        private double GetSleepRiskFactor(string sleepDuration)
        {
            return sleepDuration switch
            {
                "Meno di 5 ore" => 0.9,
                "5-6 ore" => 0.7,
                "6-7 ore" => 0.4,
                "7-8 ore" => 0.1,
                "8-9 ore" => 0.2,
                "Più di 9 ore" => 0.3,
                _ => 0.5
            };
        }

        private double GetFamilyHistoryRiskFactor(string familyHistory)
        {
            return familyHistory switch
            {
                "Sì" => 0.8,
                "No" => 0.1,
                "Non so" => 0.4,
                _ => 0.3
            };
        }

        private double GetSuicidalThoughtsRiskFactor(string suicidalThoughts)
        {
            return suicidalThoughts switch
            {
                "Mai" => 0.0,
                "Raramente" => 0.3,
                "A volte" => 0.6,
                "Spesso" => 0.8,
                "Sempre" => 1.0,
                _ => 0.4
            };
        }

        private double GetAgeRiskFactor(int age)
        {
            // Età più a rischio: 18-25
            if (age >= 18 && age <= 25) return 0.8;
            if (age >= 26 && age <= 35) return 0.6;
            if (age >= 36 && age <= 50) return 0.4;
            return 0.3;
        }

        private double GetDietaryRiskFactor(string dietaryHabits)
        {
            return dietaryHabits switch
            {
                "Molto Buone" => 0.1,
                "Buone" => 0.3,
                "Discrete" => 0.5,
                "Scarse" => 0.7,
                "Molto Scarse" => 0.9,
                _ => 0.5
            };
        }

        private double GetWorkHoursRiskFactor(int hours)
        {
            if (hours <= 6) return 0.3;
            if (hours <= 8) return 0.2;
            if (hours <= 12) return 0.4;
            if (hours <= 16) return 0.7;
            return 0.9; // Più di 16 ore
        }

        #endregion

        #region Aggiornamento Risultati

        private void UpdateResults(double riskPercentage)
        {
            // Aggiorna etichette
            lblResult.Text = $"Analisi Completata - {GetRiskLevel(riskPercentage)}";
            lblProbability.Text = $"Probabilità: {riskPercentage:F1}%";
            lblRiskLevel.Text = $"Livello di Rischio: {GetRiskLevel(riskPercentage)}";

            // Aggiorna progress bar
            progressRisk.Value = (int)Math.Min(100, riskPercentage);

            // Cambia colori in base al rischio
            if (riskPercentage <= LOW_RISK_THRESHOLD)
            {
                // Rischio Basso - Verde
                lblResult.ForeColor = Color.FromArgb(39, 174, 96);
                progressRisk.ForeColor = Color.FromArgb(39, 174, 96);
                pnlResults.BackColor = Color.FromArgb(232, 245, 233);
            }
            else if (riskPercentage <= MODERATE_RISK_THRESHOLD)
            {
                // Rischio Moderato - Arancione
                lblResult.ForeColor = Color.FromArgb(230, 126, 34);
                progressRisk.ForeColor = Color.FromArgb(230, 126, 34);
                pnlResults.BackColor = Color.FromArgb(254, 243, 224);
            }
            else
            {
                // Rischio Alto - Rosso
                lblResult.ForeColor = Color.FromArgb(231, 76, 60);
                progressRisk.ForeColor = Color.FromArgb(231, 76, 60);
                pnlResults.BackColor = Color.FromArgb(252, 228, 236);
            }

            // Mostra raccomandazioni
            ShowRecommendations(riskPercentage);
        }

        private string GetRiskLevel(double percentage)
        {
            if (percentage <= LOW_RISK_THRESHOLD)
                return "BASSO";
            else if (percentage <= MODERATE_RISK_THRESHOLD)
                return "MODERATO";
            else
                return "ALTO";
        }

        private void ShowRecommendations(double riskPercentage)
        {
            string recommendations = GetRecommendations(riskPercentage);

            MessageBox.Show(recommendations, "Raccomandazioni Personalizzate",
                MessageBoxButtons.OK,
                riskPercentage > MODERATE_RISK_THRESHOLD ? MessageBoxIcon.Warning : MessageBoxIcon.Information);
        }

        private string GetRecommendations(double riskPercentage)
        {
            if (riskPercentage <= LOW_RISK_THRESHOLD)
            {
                return "🟢 RISCHIO BASSO\n\n" +
                       "Le tue condizioni sembrano buone! Ecco alcuni consigli per mantenere il benessere:\n\n" +
                       "• Continua a mantenere un equilibrio tra studio/lavoro e vita personale\n" +
                       "• Mantieni abitudini di sonno regolari\n" +
                       "• Pratica attività fisica regolare\n" +
                       "• Coltiva relazioni sociali positive\n" +
                       "• Considera tecniche di mindfulness o meditazione";
            }
            else if (riskPercentage <= MODERATE_RISK_THRESHOLD)
            {
                return "🟡 RISCHIO MODERATO\n\n" +
                       "Alcune aree potrebbero beneficiare di attenzione. Raccomandazioni:\n\n" +
                       "• Considera di parlare con un counselor o psicologo\n" +
                       "• Valuta strategie per gestire lo stress (yoga, sport, hobby)\n" +
                       "• Migliora le abitudini del sonno e alimentari\n" +
                       "• Cerca supporto da amici, famiglia o gruppi di supporto\n" +
                       "• Considera tecniche di gestione del tempo per ridurre la pressione\n" +
                       "• Valuta se ridurre il carico di lavoro/studio se possibile";
            }
            else
            {
                return "🔴 RISCHIO ALTO\n\n" +
                       "⚠️ IMPORTANTE: È fortemente raccomandato consultare un professionista della salute mentale.\n\n" +
                       "AZIONI IMMEDIATE:\n" +
                       "• Contatta un medico, psicologo o psichiatra\n" +
                       "• Parla con qualcuno di fiducia (famiglia, amici)\n" +
                       "• Considera servizi di supporto della tua università/azienda\n" +
                       "• Telefono Amico: 199 284 284 (24h)\n" +
                       "• Samaritans Onlus: 800 86 00 22\n\n" +
                       "RICORDA: Chiedere aiuto è un segno di forza, non di debolezza.";
            }
        }

        #endregion

        #region Dati Test e Reset

        private void PopulateTestData()
        {
            // Popola con dati realistici per test
            txtAge.Text = "22";
            cmbGender.SelectedIndex = 0; // Maschio
            txtCity.Text = "Milano";
            cmbProfession.SelectedIndex = 0; // Studente
            cmbDegree.SelectedIndex = 2; // Laurea Triennale
            txtCGPA.Text = "7.5";
            txtAcademicPressure.Text = "7";
            txtWorkPressure.Text = "5";
            txtWorkStudyHours.Text = "8";
            txtStudySatisfaction.Text = "6";
            txtJobSatisfaction.Text = "7";
            txtFinancialStress.Text = "6";
            cmbSleepDuration.SelectedIndex = 2; // 6-7 ore
            cmbDietaryHabits.SelectedIndex = 2; // Discrete
            cmbFamilyHistory.SelectedIndex = 1; // No
            cmbSuicidalThoughts.SelectedIndex = 1; // Raramente
        }

        private void ResetForm()
        {
            // Reset TextBox
            txtAge.Clear();
            txtCity.Clear();
            txtCGPA.Clear();
            txtAcademicPressure.Clear();
            txtWorkPressure.Clear();
            txtWorkStudyHours.Clear();
            txtStudySatisfaction.Clear();
            txtJobSatisfaction.Clear();
            txtFinancialStress.Clear();

            // Reset ComboBox
            cmbGender.SelectedIndex = -1;
            cmbProfession.SelectedIndex = -1;
            cmbDegree.SelectedIndex = -1;
            cmbSleepDuration.SelectedIndex = -1;
            cmbDietaryHabits.SelectedIndex = -1;
            cmbFamilyHistory.SelectedIndex = -1;
            cmbSuicidalThoughts.SelectedIndex = -1;

            // Reset risultati
            lblResult.Text = "Pronto per l'analisi...";
            lblResult.ForeColor = Color.FromArgb(52, 73, 94);
            lblProbability.Text = "Probabilità: --";
            lblRiskLevel.Text = "Livello di Rischio: --";
            progressRisk.Value = 0;
            pnlResults.BackColor = Color.FromArgb(236, 240, 241);

            MessageBox.Show("Form resettato con successo!", "Reset",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region Logging e Salvataggio

        private void LogPrediction(InputData data, double risk)
        {
            try
            {
                string logPath = Path.Combine(Application.StartupPath, "predictions_log.txt");
                string logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - " +
                                 $"Età: {data.Age}, Rischio: {risk:F2}%, " +
                                 $"Livello: {GetRiskLevel(risk)}\n";

                File.AppendAllText(logPath, logEntry);
            }
            catch
            {
                // Log fallito, continua silenziosamente
            }
        }

        #endregion

        #region Struttura Dati

        public class InputData
        {
            public int Age { get; set; }
            public string Gender { get; set; }
            public string City { get; set; }
            public string Profession { get; set; }
            public string Degree { get; set; }
            public double CGPA { get; set; }
            public int AcademicPressure { get; set; }
            public int WorkPressure { get; set; }
            public int WorkStudyHours { get; set; }
            public int StudySatisfaction { get; set; }
            public int JobSatisfaction { get; set; }
            public int FinancialStress { get; set; }
            public string SleepDuration { get; set; }
            public string DietaryHabits { get; set; }
            public string FamilyHistory { get; set; }
            public string SuicidalThoughts { get; set; }
        }

        #endregion
    }
}