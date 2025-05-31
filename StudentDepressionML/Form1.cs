using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace StudentDepressionML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {
            // Imposta valori ComboBox Gender
            cmbGender.Items.Clear();
            cmbGender.Items.AddRange(new string[] { "Male", "Female" });
            cmbGender.SelectedIndex = 0;

            // Imposta valori ComboBox Profession
            cmbProfession.Items.Clear();
            cmbProfession.Items.AddRange(new string[] { "Student", "Corporate", "Business", "Housewife" });
            cmbProfession.SelectedIndex = 0;

            // Imposta valori ComboBox Sleep Duration
            cmbSleepDuration.Items.Clear();
            cmbSleepDuration.Items.AddRange(new string[] {
                "Less than 5 hours",
                "5-6 hours",
                "7-8 hours",
                "More than 8 hours"
            });
            cmbSleepDuration.SelectedIndex = 2; // Default 7-8 hours

            // Imposta valori ComboBox Dietary Habits
            cmbDietaryHabits.Items.Clear();
            cmbDietaryHabits.Items.AddRange(new string[] { "Healthy", "Moderate", "Unhealthy" });
            cmbDietaryHabits.SelectedIndex = 1; // Default Moderate

            // Imposta valori ComboBox Degree
            cmbDegree.Items.Clear();
            cmbDegree.Items.AddRange(new string[] { "Bachelor", "Master", "PhD" });
            cmbDegree.SelectedIndex = 0;

            // Imposta valori ComboBox Family History
            cmbFamilyHistory.Items.Clear();
            cmbFamilyHistory.Items.AddRange(new string[] { "Yes", "No" });
            cmbFamilyHistory.SelectedIndex = 1; // Default "No"

            // Imposta valori ComboBox Suicidal Thoughts
            cmbSuicidalThoughts.Items.Clear();
            cmbSuicidalThoughts.Items.AddRange(new string[] { "Yes", "No" });
            cmbSuicidalThoughts.SelectedIndex = 1; // Default "No"

            // Stile labels risultato
            lblResult.Font = new Font(lblResult.Font.FontFamily, 14, FontStyle.Bold);
            lblProbability.Font = new Font(lblProbability.Font.FontFamily, 11, FontStyle.Regular);
            lblRiskLevel.Font = new Font(lblRiskLevel.Font.FontFamily, 11, FontStyle.Regular);

            // Messaggi iniziali
            lblResult.Text = "Pronto per l'analisi...";
            lblProbability.Text = "Probabilità: --";
            lblRiskLevel.Text = "Livello di Rischio: --";
            progressRisk.Value = 0;

            // Valori di default per i campi numerici
            txtAge.Text = "20";
            txtCity.Text = "Milano";
            txtCGPA.Text = "7.0";
            txtAcademicPressure.Text = "5";
            txtWorkPressure.Text = "3";
            txtStudySatisfaction.Text = "7";
            txtJobSatisfaction.Text = "5";
            txtWorkStudyHours.Text = "6";
            txtFinancialStress.Text = "4";

            // Aggiungi evento per il bottone Reset
            btnReset.Click += btnReset_Click;
        }

        private void btnPredict_Click(object sender, EventArgs e)
        {
            try
            {
                // Validazione input
                if (!ValidateInputs())
                {
                    MessageBox.Show("Per favore, compila tutti i campi correttamente!",
                        "Errore Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crea input per modello ML usando TUTTI i campi del form
                var inputData = new MLModel1.ModelInput()
                {
                    // Campi dal form - mappatura diretta
                    Id = 1, // ID fittizio
                    Age = float.Parse(txtAge.Text),
                    Gender = cmbGender.SelectedItem.ToString(),
                    City = txtCity.Text,
                    Profession = cmbProfession.SelectedItem.ToString(),
                    Academic_Pressure = float.Parse(txtAcademicPressure.Text),
                    Work_Pressure = float.Parse(txtWorkPressure.Text),
                    CGPA = float.Parse(txtCGPA.Text),
                    Study_Satisfaction = float.Parse(txtStudySatisfaction.Text),
                    Job_Satisfaction = float.Parse(txtJobSatisfaction.Text),
                    Sleep_Duration = cmbSleepDuration.SelectedItem.ToString(),
                    Dietary_Habits = cmbDietaryHabits.SelectedItem.ToString(),
                    Degree = cmbDegree.SelectedItem.ToString(),
                    Have_you_ever_had_suicidal_thoughts__ = cmbSuicidalThoughts.SelectedItem.ToString() == "Yes",
                    Work_Study_Hours = float.Parse(txtWorkStudyHours.Text),
                    Financial_Stress = float.Parse(txtFinancialStress.Text),
                    Family_History_of_Mental_Illness = cmbFamilyHistory.SelectedItem.ToString() == "Yes",
                    Depression = 0 // Non usato per predizione
                };

                // Fai predizione
                var prediction = MLModel1.Predict(inputData);

                // Mostra risultati
                DisplayResults(prediction);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore durante l'analisi: {ex.Message}",
                    "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputs()
        {
            // Controlla campi di testo obbligatori
            if (string.IsNullOrWhiteSpace(txtAge.Text) ||
                string.IsNullOrWhiteSpace(txtCity.Text) ||
                string.IsNullOrWhiteSpace(txtAcademicPressure.Text) ||
                string.IsNullOrWhiteSpace(txtWorkPressure.Text) ||
                string.IsNullOrWhiteSpace(txtCGPA.Text) ||
                string.IsNullOrWhiteSpace(txtStudySatisfaction.Text) ||
                string.IsNullOrWhiteSpace(txtJobSatisfaction.Text) ||
                string.IsNullOrWhiteSpace(txtWorkStudyHours.Text) ||
                string.IsNullOrWhiteSpace(txtFinancialStress.Text))
            {
                MessageBox.Show("Alcuni campi di testo sono vuoti!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Controlla ComboBox - usa SelectedIndex invece di SelectedItem
            if (cmbGender.SelectedIndex == -1)
            {
                MessageBox.Show("Seleziona il Genere!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbProfession.SelectedIndex == -1)
            {
                MessageBox.Show("Seleziona la Professione!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbSleepDuration.SelectedIndex == -1)
            {
                MessageBox.Show("Seleziona la Durata del Sonno!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbDietaryHabits.SelectedIndex == -1)
            {
                MessageBox.Show("Seleziona le Abitudini Alimentari!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbDegree.SelectedIndex == -1)
            {
                MessageBox.Show("Seleziona il Titolo di Studio!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbFamilyHistory.SelectedIndex == -1)
            {
                MessageBox.Show("Seleziona la Storia Familiare!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbSuicidalThoughts.SelectedIndex == -1)
            {
                MessageBox.Show("Seleziona per i Pensieri Suicidi!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validazione range numerici con messaggi specifici
            if (!float.TryParse(txtAge.Text, out float age) || age < 16 || age > 35)
            {
                MessageBox.Show("Età deve essere tra 16 e 35 anni", "Errore Validazione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAge.Focus();
                return false;
            }

            if (!float.TryParse(txtAcademicPressure.Text, out float academicPressure) ||
                academicPressure < 1 || academicPressure > 10)
            {
                MessageBox.Show("Pressione Accademica deve essere tra 1 e 10", "Errore Validazione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAcademicPressure.Focus();
                return false;
            }

            if (!float.TryParse(txtWorkPressure.Text, out float workPressure) ||
                workPressure < 1 || workPressure > 10)
            {
                MessageBox.Show("Pressione Lavorativa deve essere tra 1 e 10", "Errore Validazione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtWorkPressure.Focus();
                return false;
            }

            if (!float.TryParse(txtCGPA.Text, out float cgpa) || cgpa < 0 || cgpa > 10)
            {
                MessageBox.Show("CGPA deve essere tra 0 e 10", "Errore Validazione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCGPA.Focus();
                return false;
            }

            if (!float.TryParse(txtStudySatisfaction.Text, out float studySatisfaction) ||
                studySatisfaction < 1 || studySatisfaction > 10)
            {
                MessageBox.Show("Soddisfazione Studio deve essere tra 1 e 10", "Errore Validazione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStudySatisfaction.Focus();
                return false;
            }

            if (!float.TryParse(txtJobSatisfaction.Text, out float jobSatisfaction) ||
                jobSatisfaction < 1 || jobSatisfaction > 10)
            {
                MessageBox.Show("Soddisfazione Lavoro deve essere tra 1 e 10", "Errore Validazione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtJobSatisfaction.Focus();
                return false;
            }

            if (!float.TryParse(txtWorkStudyHours.Text, out float workStudyHours) ||
                workStudyHours < 0 || workStudyHours > 20)
            {
                MessageBox.Show("Ore Studio/Lavoro devono essere tra 0 e 20", "Errore Validazione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtWorkStudyHours.Focus();
                return false;
            }

            if (!float.TryParse(txtFinancialStress.Text, out float financialStress) ||
                financialStress < 1 || financialStress > 10)
            {
                MessageBox.Show("Stress Finanziario deve essere tra 1 e 10", "Errore Validazione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFinancialStress.Focus();
                return false;
            }

            return true;
        }

        private void DisplayResults(MLModel1.ModelOutput result)
        {
            try
            {
                // Debug: stampa i valori grezzi per capire cosa restituisce il modello
                System.Diagnostics.Debug.WriteLine($"PredictedLabel: {result.PredictedLabel}");
                if (result.Score != null)
                {
                    for (int i = 0; i < result.Score.Length; i++)
                    {
                        System.Diagnostics.Debug.WriteLine($"Score[{i}]: {result.Score[i]}");
                    }
                }

                float probability = 0.5f;
                bool isDepressed = false;

                if (result.Score != null && result.Score.Length >= 2)
                {
                    // PROVA ENTRAMBE LE INTERPRETAZIONI
                    float score0 = result.Score[0];
                    float score1 = result.Score[1];

                    System.Diagnostics.Debug.WriteLine($"Score[0]: {score0:F3}");
                    System.Diagnostics.Debug.WriteLine($"Score[1]: {score1:F3}");

                    // METODO 1: Prova Score[1] come probabilità depressione
                    float probDepression1 = score1;
                    bool isDepressed1 = probDepression1 > 0.5f;

                    // METODO 2: Prova Score[0] come probabilità depressione  
                    float probDepression2 = score0;
                    bool isDepressed2 = probDepression2 > 0.5f;

                    // METODO 3: Usa il più alto tra i due score
                    float probDepression3 = Math.Max(score0, score1);
                    bool isDepressed3 = probDepression3 > 0.5f;

                    System.Diagnostics.Debug.WriteLine($"Metodo 1 (Score[1]): Prob={probDepression1:F3}, Depressed={isDepressed1}");
                    System.Diagnostics.Debug.WriteLine($"Metodo 2 (Score[0]): Prob={probDepression2:F3}, Depressed={isDepressed2}");
                    System.Diagnostics.Debug.WriteLine($"Metodo 3 (Max): Prob={probDepression3:F3}, Depressed={isDepressed3}");

                    // SCELTA LOGICA: Se uno dei due score è molto più alto dell'altro,
                    // probabilmente quello è la probabilità della classe positiva
                    if (score1 > score0)
                    {
                        // Score[1] è probabilmente la probabilità di depressione
                        probability = score1;
                        isDepressed = probability > 0.3f; // Soglia più bassa per essere più sensibili
                        System.Diagnostics.Debug.WriteLine($"Usando Score[1] come probabilità depressione");
                    }
                    else
                    {
                        // Score[0] è probabilmente la probabilità di depressione
                        probability = score0;
                        isDepressed = probability > 0.3f; // Soglia più bassa per essere più sensibili
                        System.Diagnostics.Debug.WriteLine($"Usando Score[0] come probabilità depressione");
                    }
                }
                else if (result.Score != null && result.Score.Length == 1)
                {
                    // Se c'è un solo score, usalo direttamente
                    probability = Math.Abs(result.Score[0]);
                    isDepressed = probability > 0.3f;
                }
                else
                {
                    // Fallback: usa PredictedLabel
                    if (result.PredictedLabel >= 0 && result.PredictedLabel <= 1)
                    {
                        probability = result.PredictedLabel;
                        isDepressed = probability > 0.3f;
                    }
                    else
                    {
                        // Normalizza PredictedLabel se è fuori range
                        probability = Math.Min(1.0f, Math.Max(0.0f, Math.Abs(result.PredictedLabel)));
                        isDepressed = probability > 0.3f;
                    }
                }

                // Assicurati che la probabilità sia tra 0 e 1
                probability = Math.Min(1.0f, Math.Max(0.0f, probability));

                System.Diagnostics.Debug.WriteLine($"RISULTATO FINALE: Probability={probability:F3}, IsDepressed={isDepressed}");

                // AGGIORNAMENTO INTERFACCIA
                UpdateUserInterface(isDepressed, probability, result);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore nell'interpretazione dei risultati: {ex.Message}",
                    "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateUserInterface(bool isDepressed, float probability, MLModel1.ModelOutput result)
        {
            // Aggiorna etichetta principale
            if (isDepressed)
            {
                lblResult.Text = "⚠️ RISCHIO DEPRESSIONE RILEVATO";
                lblResult.ForeColor = Color.FromArgb(231, 76, 60); // Rosso
            }
            else
            {
                lblResult.Text = "✅ NESSUN RISCHIO SIGNIFICATIVO";
                lblResult.ForeColor = Color.FromArgb(46, 204, 113); // Verde
            }

            // Aggiorna probabilità
            lblProbability.Text = $"Probabilità: {probability:P1}";
            lblProbability.ForeColor = GetColorByProbability(probability);

            // Aggiorna livello di rischio
            string riskLevel = GetRiskLevel(probability);
            lblRiskLevel.Text = $"Livello di Rischio: {riskLevel}";
            lblRiskLevel.ForeColor = GetColorByProbability(probability);

            // Aggiorna progress bar
            progressRisk.Value = Math.Min(100, Math.Max(0, (int)(probability * 100)));

            // MESSAGGIO DETTAGLIATO COERENTE
            string classification = isDepressed ? "RISCHIO DEPRESSIONE" : "NESSUN RISCHIO SIGNIFICATIVO";
            string message = $"RISULTATO ANALISI:\n\n" +
                           $"🎯 Classificazione: {classification}\n" +
                           $"📊 Probabilità: {probability:P1}\n" +
                           $"⚡ Livello Rischio: {riskLevel}\n" +
                           $"🔧 Valore Tecnico: {result.PredictedLabel:F2}\n\n" +
                           GetRecommendation(probability) + "\n\n" +
                           "💡 Questo strumento è solo indicativo e non sostituisce un consulto medico professionale.";

            MessageBox.Show(message, "Risultati Analisi",
                MessageBoxButtons.OK,
                isDepressed ? MessageBoxIcon.Warning : MessageBoxIcon.Information);
        }

        // METODI DI SUPPORTO MIGLIORATI
        private string GetRiskLevel(float prob)
        {
            if (prob >= 0.8f) return "MOLTO ALTO";
            if (prob >= 0.6f) return "ALTO";
            if (prob >= 0.4f) return "MODERATO";
            if (prob >= 0.2f) return "BASSO";
            return "MOLTO BASSO";
        }

        private string GetRecommendation(float prob)
        {
            if (prob >= 0.7f)
                return "🚨 RACCOMANDAZIONE: Consulta immediatamente un professionista della salute mentale.";
            if (prob >= 0.5f)
                return "⚠️ RACCOMANDAZIONE: Considera di cercare supporto psicologico.";
            if (prob >= 0.3f)
                return "💭 RACCOMANDAZIONE: Monitora il tuo benessere e cerca supporto sociale.";
            return "✅ RACCOMANDAZIONE: Mantieni uno stile di vita equilibrato e sano.";
        }

        private Color GetColorByProbability(float prob)
        {
            if (prob >= 0.7f) return Color.FromArgb(231, 76, 60);    // Rosso scuro - Alto rischio
            if (prob >= 0.5f) return Color.FromArgb(230, 126, 34);   // Arancione - Rischio moderato  
            if (prob >= 0.3f) return Color.FromArgb(241, 196, 15);   // Giallo - Attenzione
            return Color.FromArgb(46, 204, 113);                     // Verde - Basso rischio
        }

        private void btnTestData_Click(object sender, EventArgs e)
        {
            // Scenario 1: Alto rischio
            var testCase = MessageBox.Show("Vuoi caricare dati di ALTO RISCHIO o BASSO RISCHIO?",
                "Seleziona Test Case", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (testCase == DialogResult.Yes) // Alto rischio
            {
                // Dati che indicano alto rischio depressione
                txtAge.Text = "22";
                cmbGender.SelectedIndex = cmbGender.Items.IndexOf("Male");
                txtCity.Text = "Roma";
                cmbProfession.SelectedIndex = cmbProfession.Items.IndexOf("Student");
                txtAcademicPressure.Text = "9";
                txtWorkPressure.Text = "8";
                txtCGPA.Text = "5.5";
                txtStudySatisfaction.Text = "3";
                txtJobSatisfaction.Text = "2";
                cmbSleepDuration.SelectedIndex = cmbSleepDuration.Items.IndexOf("Less than 5 hours");
                cmbDietaryHabits.SelectedIndex = cmbDietaryHabits.Items.IndexOf("Unhealthy");
                cmbDegree.SelectedIndex = cmbDegree.Items.IndexOf("Bachelor");
                cmbSuicidalThoughts.SelectedIndex = cmbSuicidalThoughts.Items.IndexOf("Yes");
                txtWorkStudyHours.Text = "14";
                txtFinancialStress.Text = "9";
                cmbFamilyHistory.SelectedIndex = cmbFamilyHistory.Items.IndexOf("Yes");
            }
            else if (testCase == DialogResult.No) // Basso rischio
            {
                // Dati che indicano basso rischio depressione
                txtAge.Text = "20";
                cmbGender.SelectedIndex = cmbGender.Items.IndexOf("Female");
                txtCity.Text = "Milano";
                cmbProfession.SelectedIndex = cmbProfession.Items.IndexOf("Student");
                txtAcademicPressure.Text = "4";
                txtWorkPressure.Text = "3";
                txtCGPA.Text = "8.2";
                txtStudySatisfaction.Text = "8";
                txtJobSatisfaction.Text = "7";
                cmbSleepDuration.SelectedIndex = cmbSleepDuration.Items.IndexOf("7-8 hours");
                cmbDietaryHabits.SelectedIndex = cmbDietaryHabits.Items.IndexOf("Healthy");
                cmbDegree.SelectedIndex = cmbDegree.Items.IndexOf("Bachelor");
                cmbSuicidalThoughts.SelectedIndex = cmbSuicidalThoughts.Items.IndexOf("No");
                txtWorkStudyHours.Text = "6";
                txtFinancialStress.Text = "3";
                cmbFamilyHistory.SelectedIndex = cmbFamilyHistory.Items.IndexOf("No");
            }

            // Messaggio di conferma
            if (testCase != DialogResult.Cancel)
            {
                MessageBox.Show("Dati di test caricati! Ora puoi cliccare 'Analizza Rischio'.",
                    "Dati Caricati", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Reset tutti i campi ai valori predefiniti
            txtAge.Text = "20";
            cmbGender.SelectedIndex = 0;
            txtCity.Text = "Milano";
            cmbProfession.SelectedIndex = 0;
            txtAcademicPressure.Text = "5";
            txtWorkPressure.Text = "3";
            txtCGPA.Text = "7.0";
            txtStudySatisfaction.Text = "7";
            txtJobSatisfaction.Text = "5";
            cmbSleepDuration.SelectedIndex = 2;
            cmbDietaryHabits.SelectedIndex = 1;
            cmbDegree.SelectedIndex = 0;
            cmbSuicidalThoughts.SelectedIndex = 1;
            txtWorkStudyHours.Text = "6";
            txtFinancialStress.Text = "4";
            cmbFamilyHistory.SelectedIndex = 1;

            // Reset risultati
            lblResult.Text = "Pronto per l'analisi...";
            lblResult.ForeColor = Color.FromArgb(52, 73, 94);
            lblProbability.Text = "Probabilità: --";
            lblProbability.ForeColor = Color.FromArgb(52, 73, 94);
            lblRiskLevel.Text = "Livello di Rischio: --";
            lblRiskLevel.ForeColor = Color.FromArgb(52, 73, 94);
            progressRisk.Value = 0;

            MessageBox.Show("Tutti i campi sono stati resettati ai valori predefiniti.",
                "Reset Completato", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            // Evento vuoto - puoi aggiungere validazione in tempo reale se necessario
        }
        private void DebugModelOutput(MLModel1.ModelOutput result)
        {
            string debugInfo = "=== DEBUG MODEL OUTPUT ===\n";
            debugInfo += $"PredictedLabel: {result.PredictedLabel}\n";

            if (result.Score != null)
            {
                debugInfo += $"Score Array Length: {result.Score.Length}\n";
                for (int i = 0; i < result.Score.Length; i++)
                {
                    debugInfo += $"Score[{i}]: {result.Score[i]:F6}\n";
                }

                if (result.Score.Length == 2)
                {
                    float sum = result.Score[0] + result.Score[1];
                    debugInfo += $"Sum of scores: {sum:F6}\n";
                    debugInfo += $"Score[0] as %: {(result.Score[0] * 100):F2}%\n";
                    debugInfo += $"Score[1] as %: {(result.Score[1] * 100):F2}%\n";
                }
            }
            else
            {
                debugInfo += "Score: NULL\n";
            }

            debugInfo += "========================\n";

            // Mostra in console di debug
            System.Diagnostics.Debug.WriteLine(debugInfo);

            // Mostra anche in un MessageBox per vedere subito
            MessageBox.Show(debugInfo, "Debug Model Output",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Aggiungi questa chiamata nel metodo btnPredict_Click, dopo la predizione:
        // DebugModelOutput(prediction);
    }
}