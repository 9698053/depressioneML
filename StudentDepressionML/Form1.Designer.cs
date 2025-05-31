namespace StudentDepressionML
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            // Pannelli principali
            pnlHeader = new Panel();
            pnlMain = new Panel();
            pnlFooter = new Panel();

            // Header
            lblTitle = new Label();
            lblSubtitle = new Label();

            // Sezioni dati
            pnlPersonalInfo = new Panel();
            lblPersonalInfo = new Label();
            pnlAcademicWork = new Panel();
            lblAcademicWork = new Label();
            pnlLifestyle = new Panel();
            lblLifestyle = new Label();
            pnlMentalHealth = new Panel();
            lblMentalHealth = new Label();

            // Controlli input
            lblAge = new Label();
            txtAge = new TextBox();
            lblGender = new Label();
            cmbGender = new ComboBox();
            lblCity = new Label();
            txtCity = new TextBox();
            lblProfession = new Label();
            cmbProfession = new ComboBox();
            lblDegree = new Label();
            cmbDegree = new ComboBox();
            lblCGPA = new Label();
            txtCGPA = new TextBox();
            lblAcademicPressure = new Label();
            txtAcademicPressure = new TextBox();
            lblWorkPressure = new Label();
            txtWorkPressure = new TextBox();
            lblWorkStudyHours = new Label();
            txtWorkStudyHours = new TextBox();
            lblStudySatisfaction = new Label();
            txtStudySatisfaction = new TextBox();
            lblJobSatisfaction = new Label();
            txtJobSatisfaction = new TextBox();
            lblFinancialStress = new Label();
            txtFinancialStress = new TextBox();
            lblSleepDuration = new Label();
            cmbSleepDuration = new ComboBox();
            lblDietaryHabits = new Label();
            cmbDietaryHabits = new ComboBox();
            lblFamilyHistory = new Label();
            cmbFamilyHistory = new ComboBox();
            lblSuicidalThoughts = new Label();
            cmbSuicidalThoughts = new ComboBox();

            // Bottoni e risultati
            btnPredict = new Button();
            btnTestData = new Button();
            btnReset = new Button();
            pnlResults = new Panel();
            lblResult = new Label();
            lblProbability = new Label();
            lblRiskLevel = new Label();
            progressRisk = new ProgressBar();

            SuspendLayout();

            // =====================
            // CONFIGURAZIONE FORM
            // =====================
            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(245, 248, 250);
            this.ClientSize = new Size(1000, 700);
            this.Font = new Font("Segoe UI", 9F);
            this.MinimumSize = new Size(1000, 700);
            this.Name = "Form1";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Mental Health Risk Assessment Tool";

            // =====================
            // HEADER PANEL
            // =====================
            pnlHeader.BackColor = Color.FromArgb(41, 128, 185);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 80;
            pnlHeader.Padding = new Padding(20, 10, 20, 10);

            lblTitle.Text = "🧠 ANALISI RISCHIO DEPRESSIONE";
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(20, 15);

            lblSubtitle.Text = "Strumento di valutazione del benessere mentale per studenti";
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(236, 240, 241);
            lblSubtitle.AutoSize = true;
            lblSubtitle.Location = new Point(20, 45);

            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblSubtitle);

            // =====================
            // MAIN PANEL
            // =====================
            pnlMain.AutoScroll = true;
            pnlMain.BackColor = Color.FromArgb(245, 248, 250);
            pnlMain.Dock = DockStyle.None;
            pnlMain.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            pnlMain.Location = new Point(0, 80);  // 80 è l'altezza dell'header
            pnlMain.Size = new Size(this.ClientSize.Width, this.ClientSize.Height - 160); // 80 header + 80 footer
            pnlMain.Padding = new Padding(20);

            // =====================
            // SEZIONE INFORMAZIONI PERSONALI
            // =====================
            pnlPersonalInfo.BackColor = Color.White;
            pnlPersonalInfo.Location = new Point(20, 20);
            pnlPersonalInfo.Size = new Size(940, 120);
            pnlPersonalInfo.BorderStyle = BorderStyle.None;
            pnlPersonalInfo.Padding = new Padding(20);

            lblPersonalInfo.Text = "👤 INFORMAZIONI PERSONALI";
            lblPersonalInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPersonalInfo.ForeColor = Color.FromArgb(52, 73, 94);
            lblPersonalInfo.Location = new Point(20, 15);
            lblPersonalInfo.AutoSize = true;

            // Età
            lblAge.Text = "Età:";
            lblAge.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAge.ForeColor = Color.FromArgb(52, 73, 94);
            lblAge.Location = new Point(30, 50);
            lblAge.Size = new Size(80, 20);

            txtAge.Location = new Point(30, 70);
            txtAge.Size = new Size(120, 25);
            txtAge.Font = new Font("Segoe UI", 9F);
            txtAge.BorderStyle = BorderStyle.FixedSingle;

            // Genere
            lblGender.Text = "Genere:";
            lblGender.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblGender.ForeColor = Color.FromArgb(52, 73, 94);
            lblGender.Location = new Point(180, 50);
            lblGender.Size = new Size(80, 20);

            cmbGender.Location = new Point(180, 70);
            cmbGender.Size = new Size(120, 25);
            cmbGender.Font = new Font("Segoe UI", 9F);
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.FlatStyle = FlatStyle.Flat;

            // Città
            lblCity.Text = "Città:";
            lblCity.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCity.ForeColor = Color.FromArgb(52, 73, 94);
            lblCity.Location = new Point(330, 50);
            lblCity.Size = new Size(80, 20);

            txtCity.Location = new Point(330, 70);
            txtCity.Size = new Size(120, 25);
            txtCity.Font = new Font("Segoe UI", 9F);
            txtCity.BorderStyle = BorderStyle.FixedSingle;

            // Professione
            lblProfession.Text = "Professione:";
            lblProfession.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblProfession.ForeColor = Color.FromArgb(52, 73, 94);
            lblProfession.Location = new Point(480, 50);
            lblProfession.Size = new Size(80, 20);

            cmbProfession.Location = new Point(480, 70);
            cmbProfession.Size = new Size(120, 25);
            cmbProfession.Font = new Font("Segoe UI", 9F);
            cmbProfession.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProfession.FlatStyle = FlatStyle.Flat;

            // Laurea
            lblDegree.Text = "Titolo di Studio:";
            lblDegree.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDegree.ForeColor = Color.FromArgb(52, 73, 94);
            lblDegree.Location = new Point(630, 50);
            lblDegree.Size = new Size(100, 20);

            cmbDegree.Location = new Point(630, 70);
            cmbDegree.Size = new Size(120, 25);
            cmbDegree.Font = new Font("Segoe UI", 9F);
            cmbDegree.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDegree.FlatStyle = FlatStyle.Flat;

            pnlPersonalInfo.Controls.AddRange(new Control[] {
                lblPersonalInfo, lblAge, txtAge, lblGender, cmbGender,
                lblCity, txtCity, lblProfession, cmbProfession,
                lblDegree, cmbDegree
            });

            // =====================
            // SEZIONE ACCADEMICO/LAVORATIVO
            // =====================
            pnlAcademicWork.BackColor = Color.White;
            pnlAcademicWork.Location = new Point(20, 160);
            pnlAcademicWork.Size = new Size(940, 180);
            pnlAcademicWork.BorderStyle = BorderStyle.None;
            pnlAcademicWork.Padding = new Padding(20);

            lblAcademicWork.Text = "📚 PERFORMANCE ACCADEMICO/LAVORATIVO";
            lblAcademicWork.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAcademicWork.ForeColor = Color.FromArgb(52, 73, 94);
            lblAcademicWork.Location = new Point(20, 15);
            lblAcademicWork.AutoSize = true;

            // CGPA
            lblCGPA.Text = "CGPA (0-10):";
            lblCGPA.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCGPA.ForeColor = Color.FromArgb(52, 73, 94);
            lblCGPA.Location = new Point(30, 50);
            lblCGPA.Size = new Size(100, 20);

            txtCGPA.Location = new Point(30, 70);
            txtCGPA.Size = new Size(120, 25);
            txtCGPA.Font = new Font("Segoe UI", 9F);
            txtCGPA.BorderStyle = BorderStyle.FixedSingle;

            // Pressione Accademica
            lblAcademicPressure.Text = "Pressione Accademica (1-10):";
            lblAcademicPressure.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAcademicPressure.ForeColor = Color.FromArgb(52, 73, 94);
            lblAcademicPressure.Location = new Point(180, 50);
            lblAcademicPressure.Size = new Size(200, 20);

            txtAcademicPressure.Location = new Point(180, 70);
            txtAcademicPressure.Size = new Size(120, 25);
            txtAcademicPressure.Font = new Font("Segoe UI", 9F);
            txtAcademicPressure.BorderStyle = BorderStyle.FixedSingle;

            // Pressione Lavorativa
            lblWorkPressure.Text = "Pressione Lavorativa (1-10):";
            lblWorkPressure.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblWorkPressure.ForeColor = Color.FromArgb(52, 73, 94);
            lblWorkPressure.Location = new Point(380, 50);
            lblWorkPressure.Size = new Size(200, 20);

            txtWorkPressure.Location = new Point(380, 70);
            txtWorkPressure.Size = new Size(120, 25);
            txtWorkPressure.Font = new Font("Segoe UI", 9F);
            txtWorkPressure.BorderStyle = BorderStyle.FixedSingle;

            // Ore Studio/Lavoro
            lblWorkStudyHours.Text = "Ore Studio/Lavoro al giorno:";
            lblWorkStudyHours.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblWorkStudyHours.ForeColor = Color.FromArgb(52, 73, 94);
            lblWorkStudyHours.Location = new Point(580, 50);
            lblWorkStudyHours.Size = new Size(200, 20);

            txtWorkStudyHours.Location = new Point(580, 70);
            txtWorkStudyHours.Size = new Size(120, 25);
            txtWorkStudyHours.Font = new Font("Segoe UI", 9F);
            txtWorkStudyHours.BorderStyle = BorderStyle.FixedSingle;

            // Soddisfazione Studio
            lblStudySatisfaction.Text = "Soddisfazione Studio (1-10):";
            lblStudySatisfaction.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStudySatisfaction.ForeColor = Color.FromArgb(52, 73, 94);
            lblStudySatisfaction.Location = new Point(30, 110);
            lblStudySatisfaction.Size = new Size(200, 20);

            txtStudySatisfaction.Location = new Point(30, 130);
            txtStudySatisfaction.Size = new Size(120, 25);
            txtStudySatisfaction.Font = new Font("Segoe UI", 9F);
            txtStudySatisfaction.BorderStyle = BorderStyle.FixedSingle;

            // Soddisfazione Lavoro
            lblJobSatisfaction.Text = "Soddisfazione Lavoro (1-10):";
            lblJobSatisfaction.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblJobSatisfaction.ForeColor = Color.FromArgb(52, 73, 94);
            lblJobSatisfaction.Location = new Point(230, 110);
            lblJobSatisfaction.Size = new Size(200, 20);

            txtJobSatisfaction.Location = new Point(230, 130);
            txtJobSatisfaction.Size = new Size(120, 25);
            txtJobSatisfaction.Font = new Font("Segoe UI", 9F);
            txtJobSatisfaction.BorderStyle = BorderStyle.FixedSingle;

            // Stress Finanziario
            lblFinancialStress.Text = "Stress Finanziario (1-10):";
            lblFinancialStress.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFinancialStress.ForeColor = Color.FromArgb(52, 73, 94);
            lblFinancialStress.Location = new Point(380, 110);
            lblFinancialStress.Size = new Size(200, 20);

            txtFinancialStress.Location = new Point(380, 130);
            txtFinancialStress.Size = new Size(120, 25);
            txtFinancialStress.Font = new Font("Segoe UI", 9F);
            txtFinancialStress.BorderStyle = BorderStyle.FixedSingle;

            pnlAcademicWork.Controls.AddRange(new Control[] {
                lblAcademicWork, lblCGPA, txtCGPA, lblAcademicPressure, txtAcademicPressure,
                lblWorkPressure, txtWorkPressure, lblWorkStudyHours, txtWorkStudyHours,
                lblStudySatisfaction, txtStudySatisfaction, lblJobSatisfaction, txtJobSatisfaction,
                lblFinancialStress, txtFinancialStress
            });

            // =====================
            // SEZIONE STILE DI VITA
            // =====================
            pnlLifestyle.BackColor = Color.White;
            pnlLifestyle.Location = new Point(20, 360);
            pnlLifestyle.Size = new Size(940, 120);
            pnlLifestyle.BorderStyle = BorderStyle.None;
            pnlLifestyle.Padding = new Padding(20);

            lblLifestyle.Text = "🌱 STILE DI VITA";
            lblLifestyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblLifestyle.ForeColor = Color.FromArgb(52, 73, 94);
            lblLifestyle.Location = new Point(20, 15);
            lblLifestyle.AutoSize = true;

            // Durata Sonno
            lblSleepDuration.Text = "Durata del Sonno:";
            lblSleepDuration.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSleepDuration.ForeColor = Color.FromArgb(52, 73, 94);
            lblSleepDuration.Location = new Point(30, 50);
            lblSleepDuration.Size = new Size(120, 20);

            cmbSleepDuration.Location = new Point(30, 70);
            cmbSleepDuration.Size = new Size(200, 25);
            cmbSleepDuration.Font = new Font("Segoe UI", 9F);
            cmbSleepDuration.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSleepDuration.FlatStyle = FlatStyle.Flat;

            // Abitudini Alimentari
            lblDietaryHabits.Text = "Abitudini Alimentari:";
            lblDietaryHabits.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDietaryHabits.ForeColor = Color.FromArgb(52, 73, 94);
            lblDietaryHabits.Location = new Point(280, 50);
            lblDietaryHabits.Size = new Size(130, 20);

            cmbDietaryHabits.Location = new Point(280, 70);
            cmbDietaryHabits.Size = new Size(150, 25);
            cmbDietaryHabits.Font = new Font("Segoe UI", 9F);
            cmbDietaryHabits.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDietaryHabits.FlatStyle = FlatStyle.Flat;

            pnlLifestyle.Controls.AddRange(new Control[] {
                lblLifestyle, lblSleepDuration, cmbSleepDuration,
                lblDietaryHabits, cmbDietaryHabits
            });

            // =====================
            // SEZIONE SALUTE MENTALE
            // =====================
            pnlMentalHealth.BackColor = Color.White;
            pnlMentalHealth.Location = new Point(20, 500);
            pnlMentalHealth.Size = new Size(940, 120);
            pnlMentalHealth.BorderStyle = BorderStyle.None;
            pnlMentalHealth.Padding = new Padding(20);

            lblMentalHealth.Text = "🧘 SALUTE MENTALE";
            lblMentalHealth.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMentalHealth.ForeColor = Color.FromArgb(52, 73, 94);
            lblMentalHealth.Location = new Point(20, 15);
            lblMentalHealth.AutoSize = true;

            // Storia Familiare
            lblFamilyHistory.Text = "Storia Familiare di Malattie Mentali:";
            lblFamilyHistory.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFamilyHistory.ForeColor = Color.FromArgb(52, 73, 94);
            lblFamilyHistory.Location = new Point(30, 50);
            lblFamilyHistory.Size = new Size(200, 20);

            cmbFamilyHistory.Location = new Point(30, 70);
            cmbFamilyHistory.Size = new Size(120, 25);
            cmbFamilyHistory.Font = new Font("Segoe UI", 9F);
            cmbFamilyHistory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFamilyHistory.FlatStyle = FlatStyle.Flat;

            // Pensieri Suicidi
            lblSuicidalThoughts.Text = "Pensieri Suicidi:";
            lblSuicidalThoughts.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSuicidalThoughts.ForeColor = Color.FromArgb(52, 73, 94);
            lblSuicidalThoughts.Location = new Point(280, 50);
            lblSuicidalThoughts.Size = new Size(120, 20);

            cmbSuicidalThoughts.Location = new Point(280, 70);
            cmbSuicidalThoughts.Size = new Size(120, 25);
            cmbSuicidalThoughts.Font = new Font("Segoe UI", 9F);
            cmbSuicidalThoughts.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSuicidalThoughts.FlatStyle = FlatStyle.Flat;

            pnlMentalHealth.Controls.AddRange(new Control[] {
                lblMentalHealth, lblFamilyHistory, cmbFamilyHistory,
                lblSuicidalThoughts, cmbSuicidalThoughts
            });

            // =====================
            // PANNELLO RISULTATI
            // =====================
            pnlResults.BackColor = Color.FromArgb(236, 240, 241);
            pnlResults.Location = new Point(20, 640);
            pnlResults.Size = new Size(940, 120);
            pnlResults.BorderStyle = BorderStyle.None;
            pnlResults.Padding = new Padding(20);

            lblResult.Text = "Pronto per l'analisi...";
            lblResult.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblResult.ForeColor = Color.FromArgb(52, 73, 94);
            lblResult.Location = new Point(20, 20);
            lblResult.Size = new Size(400, 30);

            lblProbability.Text = "Probabilità: --";
            lblProbability.Font = new Font("Segoe UI", 11F);
            lblProbability.ForeColor = Color.FromArgb(52, 73, 94);
            lblProbability.Location = new Point(20, 50);
            lblProbability.Size = new Size(200, 25);

            lblRiskLevel.Text = "Livello di Rischio: --";
            lblRiskLevel.Font = new Font("Segoe UI", 11F);
            lblRiskLevel.ForeColor = Color.FromArgb(52, 73, 94);
            lblRiskLevel.Location = new Point(250, 50);
            lblRiskLevel.Size = new Size(200, 25);

            progressRisk.Location = new Point(20, 80);
            progressRisk.Size = new Size(450, 20);
            progressRisk.Style = ProgressBarStyle.Continuous;
            progressRisk.ForeColor = Color.FromArgb(46, 204, 113);

            pnlResults.Controls.AddRange(new Control[] {
                lblResult, lblProbability, lblRiskLevel, progressRisk
            });

            // =====================
            // FOOTER PANEL
            // =====================
            pnlFooter.BackColor = Color.FromArgb(52, 73, 94);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Height = 80;
            pnlFooter.Padding = new Padding(20, 15, 20, 15);

            // Bottone Analizza
            btnPredict.BackColor = Color.FromArgb(46, 204, 113);
            btnPredict.FlatStyle = FlatStyle.Flat;
            btnPredict.FlatAppearance.BorderSize = 0;
            btnPredict.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnPredict.ForeColor = Color.White;
            btnPredict.Location = new Point(20, 20);
            btnPredict.Size = new Size(180, 40);
            btnPredict.Text = "🔍 ANALIZZA RISCHIO";
            btnPredict.UseVisualStyleBackColor = false;
            btnPredict.Cursor = Cursors.Hand;
            btnPredict.Click += btnPredict_Click;

            // Bottone Dati Test
            btnTestData.BackColor = Color.FromArgb(230, 126, 34);
            btnTestData.FlatStyle = FlatStyle.Flat;
            btnTestData.FlatAppearance.BorderSize = 0;
            btnTestData.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnTestData.ForeColor = Color.White;
            btnTestData.Location = new Point(220, 20);
            btnTestData.Size = new Size(150, 40);
            btnTestData.Text = "📊 DATI TEST";
            btnTestData.UseVisualStyleBackColor = false;
            btnTestData.Cursor = Cursors.Hand;
            btnTestData.Click += btnTestData_Click;

            // Bottone Reset
            btnReset.BackColor = Color.FromArgb(149, 165, 166);
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(390, 20);
            btnReset.Size = new Size(120, 40);
            btnReset.Text = "🔄 RESET";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Cursor = Cursors.Hand;
 

            pnlFooter.Controls.AddRange(new Control[] {
                btnPredict, btnTestData, btnReset
            });

            // Aggiungi tutti i pannelli principali al form
            pnlMain.Controls.AddRange(new Control[] {
                pnlPersonalInfo, pnlAcademicWork, pnlLifestyle, pnlMentalHealth, pnlResults
            });

            this.Controls.AddRange(new Control[] {
                pnlHeader, pnlMain, pnlFooter
            });

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // Pannelli principali
        private Panel pnlHeader;
        private Panel pnlMain;
        private Panel pnlFooter;

        // Header
        private Label lblTitle;
        private Label lblSubtitle;

        // Sezioni
        private Panel pnlPersonalInfo;
        private Label lblPersonalInfo;
        private Panel pnlAcademicWork;
        private Label lblAcademicWork;
        private Panel pnlLifestyle;
        private Label lblLifestyle;
        private Panel pnlMentalHealth;
        private Label lblMentalHealth;

        // Controlli input
        private Label lblAge;
        private TextBox txtAge;
        private Label lblGender;
        private ComboBox cmbGender;
        private Label lblCity;
        private TextBox txtCity;
        private Label lblProfession;
        private ComboBox cmbProfession;
        private Label lblAcademicPressure;
        private TextBox txtAcademicPressure;
        private Label lblWorkPressure;
        private TextBox txtWorkPressure;
        private Label lblCGPA;
        private TextBox txtCGPA;
        private Label lblStudySatisfaction;
        private TextBox txtStudySatisfaction;
        private Label lblJobSatisfaction;
        private TextBox txtJobSatisfaction;
        private Label lblSleepDuration;
        private ComboBox cmbSleepDuration;
        private Label lblDietaryHabits;
        private ComboBox cmbDietaryHabits;
        private Label lblDegree;
        private ComboBox cmbDegree;
        private Label lblSuicidalThoughts;
        private ComboBox cmbSuicidalThoughts;
        private Label lblWorkStudyHours;
        private TextBox txtWorkStudyHours;
        private Label lblFinancialStress;
        private TextBox txtFinancialStress;
        private Label lblFamilyHistory;
        private ComboBox cmbFamilyHistory;

        // Bottoni e risultati
        private Button btnPredict;
        private Button btnTestData;
        private Button btnReset;
        private Panel pnlResults;
        private Label lblResult;
        private Label lblProbability;
        private Label lblRiskLevel;
        private ProgressBar progressRisk;
    }
}