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
            pnlSidebar = new Panel();

            // Header
            lblTitle = new Label();
            lblSubtitle = new Label();
            picIcon = new PictureBox();

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
            btnSave = new Button();
            pnlResults = new Panel();
            lblResult = new Label();
            lblProbability = new Label();
            lblRiskLevel = new Label();
            progressRisk = new ProgressBar();
            lblRecommendations = new Label();

            // Info panel sidebar
            lblInfo = new Label();
            lblVersion = new Label();

            SuspendLayout();

            // =====================
            // CONFIGURAZIONE FORM
            // =====================
            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(240, 244, 248);
            this.ClientSize = new Size(1200, 800);
            this.Font = new Font("Segoe UI", 9F);
            this.MinimumSize = new Size(1200, 800);
            this.Name = "Form1";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Mental Health Risk Assessment Tool - Advanced";
            this.WindowState = FormWindowState.Maximized;

            // =====================
            // HEADER PANEL
            // =====================
            pnlHeader.BackColor = Color.FromArgb(30, 139, 195);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 100;
            pnlHeader.Padding = new Padding(30, 15, 30, 15);

            // Icon placeholder
            picIcon.BackColor = Color.Transparent;
            picIcon.Location = new Point(30, 25);
            picIcon.Size = new Size(50, 50);
            picIcon.SizeMode = PictureBoxSizeMode.CenterImage;

            lblTitle.Text = "🧠 ANALISI RISCHIO DEPRESSIONE";
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(100, 20);

            lblSubtitle.Text = "Strumento avanzato di valutazione del benessere mentale per studenti e professionisti";
            lblSubtitle.Font = new Font("Segoe UI", 11F);
            lblSubtitle.ForeColor = Color.FromArgb(220, 235, 245);
            lblSubtitle.AutoSize = true;
            lblSubtitle.Location = new Point(100, 55);

            pnlHeader.Controls.Add(picIcon);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblSubtitle);

            // =====================
            // SIDEBAR PANEL
            // =====================
            pnlSidebar.BackColor = Color.FromArgb(52, 73, 94);
            pnlSidebar.Dock = DockStyle.Right;
            pnlSidebar.Width = 280;
            pnlSidebar.Padding = new Padding(20);

            lblInfo.Text = "ℹ️ INFORMAZIONI\n\n" +
                          "Questo strumento utilizza algoritmi di\n" +
                          "machine learning per valutare il rischio\n" +
                          "di depressione basandosi su diversi\n" +
                          "fattori personali, accademici e di\n" +
                          "stile di vita.\n\n" +
                          "⚠️ IMPORTANTE:\n" +
                          "Questo tool è solo a scopo educativo\n" +
                          "e non sostituisce una consulenza\n" +
                          "medica professionale.\n\n" +
                          "📊 LIVELLI DI RISCHIO:\n" +
                          "🟢 Basso (0-30%)\n" +
                          "🟡 Moderato (31-60%)\n" +
                          "🔴 Alto (61-100%)";
            lblInfo.Font = new Font("Segoe UI", 9F);
            lblInfo.ForeColor = Color.White;
            lblInfo.Location = new Point(20, 20);
            lblInfo.Size = new Size(240, 400);

            lblVersion.Text = "Versione 2.0 - Dicembre 2024";
            lblVersion.Font = new Font("Segoe UI", 8F, FontStyle.Italic);
            lblVersion.ForeColor = Color.FromArgb(149, 165, 166);
            lblVersion.Location = new Point(20, 450);
            lblVersion.Size = new Size(240, 20);

            pnlSidebar.Controls.Add(lblInfo);
            pnlSidebar.Controls.Add(lblVersion);

            // =====================
            // MAIN PANEL
            // =====================
            pnlMain.AutoScroll = true;
            pnlMain.BackColor = Color.FromArgb(240, 244, 248);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Padding = new Padding(30, 20, 30, 20);

            // =====================
            // SEZIONE INFORMAZIONI PERSONALI
            // =====================
            pnlPersonalInfo.BackColor = Color.White;
            pnlPersonalInfo.Location = new Point(30, 20);
            pnlPersonalInfo.Size = new Size(840, 140);
            pnlPersonalInfo.BorderStyle = BorderStyle.None;
            pnlPersonalInfo.Padding = new Padding(25);
            // Aggiungi ombra con un bordo arrotondato simulato
            pnlPersonalInfo.BackColor = Color.White;

            lblPersonalInfo.Text = "👤 INFORMAZIONI PERSONALI";
            lblPersonalInfo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblPersonalInfo.ForeColor = Color.FromArgb(30, 139, 195);
            lblPersonalInfo.Location = new Point(25, 20);
            lblPersonalInfo.AutoSize = true;

            // Età
            lblAge.Text = "Età";
            lblAge.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAge.ForeColor = Color.FromArgb(52, 73, 94);
            lblAge.Location = new Point(35, 60);
            lblAge.Size = new Size(120, 20);

            txtAge.Location = new Point(35, 85);
            txtAge.Size = new Size(130, 27);
            txtAge.Font = new Font("Segoe UI", 10F);
            txtAge.BorderStyle = BorderStyle.FixedSingle;
            txtAge.BackColor = Color.FromArgb(248, 249, 250);

            // Genere
            lblGender.Text = "Genere";
            lblGender.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblGender.ForeColor = Color.FromArgb(52, 73, 94);
            lblGender.Location = new Point(200, 60);
            lblGender.Size = new Size(120, 20);

            cmbGender.Location = new Point(200, 85);
            cmbGender.Size = new Size(130, 27);
            cmbGender.Font = new Font("Segoe UI", 10F);
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.FlatStyle = FlatStyle.Flat;
            cmbGender.BackColor = Color.FromArgb(248, 249, 250);

            // Città
            lblCity.Text = "Città";
            lblCity.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCity.ForeColor = Color.FromArgb(52, 73, 94);
            lblCity.Location = new Point(365, 60);
            lblCity.Size = new Size(120, 20);

            txtCity.Location = new Point(365, 85);
            txtCity.Size = new Size(130, 27);
            txtCity.Font = new Font("Segoe UI", 10F);
            txtCity.BorderStyle = BorderStyle.FixedSingle;
            txtCity.BackColor = Color.FromArgb(248, 249, 250);

            // Professione
            lblProfession.Text = "Professione";
            lblProfession.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblProfession.ForeColor = Color.FromArgb(52, 73, 94);
            lblProfession.Location = new Point(530, 60);
            lblProfession.Size = new Size(120, 20);

            cmbProfession.Location = new Point(530, 85);
            cmbProfession.Size = new Size(130, 27);
            cmbProfession.Font = new Font("Segoe UI", 10F);
            cmbProfession.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProfession.FlatStyle = FlatStyle.Flat;
            cmbProfession.BackColor = Color.FromArgb(248, 249, 250);

            // Laurea
            lblDegree.Text = "Titolo di Studio";
            lblDegree.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDegree.ForeColor = Color.FromArgb(52, 73, 94);
            lblDegree.Location = new Point(695, 60);
            lblDegree.Size = new Size(120, 20);

            cmbDegree.Location = new Point(695, 85);
            cmbDegree.Size = new Size(130, 27);
            cmbDegree.Font = new Font("Segoe UI", 10F);
            cmbDegree.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDegree.FlatStyle = FlatStyle.Flat;
            cmbDegree.BackColor = Color.FromArgb(248, 249, 250);

            pnlPersonalInfo.Controls.AddRange(new Control[] {
                lblPersonalInfo, lblAge, txtAge, lblGender, cmbGender,
                lblCity, txtCity, lblProfession, cmbProfession,
                lblDegree, cmbDegree
            });

            // =====================
            // SEZIONE ACCADEMICO/LAVORATIVO
            // =====================
            pnlAcademicWork.BackColor = Color.White;
            pnlAcademicWork.Location = new Point(30, 180);
            pnlAcademicWork.Size = new Size(840, 220);
            pnlAcademicWork.BorderStyle = BorderStyle.None;
            pnlAcademicWork.Padding = new Padding(25);

            lblAcademicWork.Text = "📚 PERFORMANCE ACCADEMICO/LAVORATIVO";
            lblAcademicWork.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblAcademicWork.ForeColor = Color.FromArgb(39, 174, 96);
            lblAcademicWork.Location = new Point(25, 20);
            lblAcademicWork.AutoSize = true;

            // Prima riga di controlli
            // CGPA
            lblCGPA.Text = "CGPA (0-10)";
            lblCGPA.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCGPA.ForeColor = Color.FromArgb(52, 73, 94);
            lblCGPA.Location = new Point(35, 60);
            lblCGPA.Size = new Size(120, 20);

            txtCGPA.Location = new Point(35, 85);
            txtCGPA.Size = new Size(130, 27);
            txtCGPA.Font = new Font("Segoe UI", 10F);
            txtCGPA.BorderStyle = BorderStyle.FixedSingle;
            txtCGPA.BackColor = Color.FromArgb(248, 249, 250);

            // Pressione Accademica
            lblAcademicPressure.Text = "Pressione Accademica (1-10)";
            lblAcademicPressure.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAcademicPressure.ForeColor = Color.FromArgb(52, 73, 94);
            lblAcademicPressure.Location = new Point(200, 60);
            lblAcademicPressure.Size = new Size(180, 20);

            txtAcademicPressure.Location = new Point(200, 85);
            txtAcademicPressure.Size = new Size(130, 27);
            txtAcademicPressure.Font = new Font("Segoe UI", 10F);
            txtAcademicPressure.BorderStyle = BorderStyle.FixedSingle;
            txtAcademicPressure.BackColor = Color.FromArgb(248, 249, 250);

            // Pressione Lavorativa
            lblWorkPressure.Text = "Pressione Lavorativa (1-10)";
            lblWorkPressure.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblWorkPressure.ForeColor = Color.FromArgb(52, 73, 94);
            lblWorkPressure.Location = new Point(365, 60);
            lblWorkPressure.Size = new Size(180, 20);

            txtWorkPressure.Location = new Point(365, 85);
            txtWorkPressure.Size = new Size(130, 27);
            txtWorkPressure.Font = new Font("Segoe UI", 10F);
            txtWorkPressure.BorderStyle = BorderStyle.FixedSingle;
            txtWorkPressure.BackColor = Color.FromArgb(248, 249, 250);

            // Ore Studio/Lavoro
            lblWorkStudyHours.Text = "Ore Studio/Lavoro al giorno";
            lblWorkStudyHours.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblWorkStudyHours.ForeColor = Color.FromArgb(52, 73, 94);
            lblWorkStudyHours.Location = new Point(530, 60);
            lblWorkStudyHours.Size = new Size(180, 20);

            txtWorkStudyHours.Location = new Point(530, 85);
            txtWorkStudyHours.Size = new Size(130, 27);
            txtWorkStudyHours.Font = new Font("Segoe UI", 10F);
            txtWorkStudyHours.BorderStyle = BorderStyle.FixedSingle;
            txtWorkStudyHours.BackColor = Color.FromArgb(248, 249, 250);

            // Seconda riga di controlli
            // Soddisfazione Studio
            lblStudySatisfaction.Text = "Soddisfazione Studio (1-10)";
            lblStudySatisfaction.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStudySatisfaction.ForeColor = Color.FromArgb(52, 73, 94);
            lblStudySatisfaction.Location = new Point(35, 130);
            lblStudySatisfaction.Size = new Size(180, 20);

            txtStudySatisfaction.Location = new Point(35, 155);
            txtStudySatisfaction.Size = new Size(130, 27);
            txtStudySatisfaction.Font = new Font("Segoe UI", 10F);
            txtStudySatisfaction.BorderStyle = BorderStyle.FixedSingle;
            txtStudySatisfaction.BackColor = Color.FromArgb(248, 249, 250);

            // Soddisfazione Lavoro
            lblJobSatisfaction.Text = "Soddisfazione Lavoro (1-10)";
            lblJobSatisfaction.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblJobSatisfaction.ForeColor = Color.FromArgb(52, 73, 94);
            lblJobSatisfaction.Location = new Point(200, 130);
            lblJobSatisfaction.Size = new Size(180, 20);

            txtJobSatisfaction.Location = new Point(200, 155);
            txtJobSatisfaction.Size = new Size(130, 27);
            txtJobSatisfaction.Font = new Font("Segoe UI", 10F);
            txtJobSatisfaction.BorderStyle = BorderStyle.FixedSingle;
            txtJobSatisfaction.BackColor = Color.FromArgb(248, 249, 250);

            // Stress Finanziario
            lblFinancialStress.Text = "Stress Finanziario (1-10)";
            lblFinancialStress.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFinancialStress.ForeColor = Color.FromArgb(52, 73, 94);
            lblFinancialStress.Location = new Point(365, 130);
            lblFinancialStress.Size = new Size(180, 20);

            txtFinancialStress.Location = new Point(365, 155);
            txtFinancialStress.Size = new Size(130, 27);
            txtFinancialStress.Font = new Font("Segoe UI", 10F);
            txtFinancialStress.BorderStyle = BorderStyle.FixedSingle;
            txtFinancialStress.BackColor = Color.FromArgb(248, 249, 250);

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
            pnlLifestyle.Location = new Point(30, 420);
            pnlLifestyle.Size = new Size(840, 140);
            pnlLifestyle.BorderStyle = BorderStyle.None;
            pnlLifestyle.Padding = new Padding(25);

            lblLifestyle.Text = "🌱 STILE DI VITA";
            lblLifestyle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblLifestyle.ForeColor = Color.FromArgb(230, 126, 34);
            lblLifestyle.Location = new Point(25, 20);
            lblLifestyle.AutoSize = true;

            // Durata Sonno
            lblSleepDuration.Text = "Durata del Sonno";
            lblSleepDuration.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSleepDuration.ForeColor = Color.FromArgb(52, 73, 94);
            lblSleepDuration.Location = new Point(35, 60);
            lblSleepDuration.Size = new Size(150, 20);

            cmbSleepDuration.Location = new Point(35, 85);
            cmbSleepDuration.Size = new Size(220, 27);
            cmbSleepDuration.Font = new Font("Segoe UI", 10F);
            cmbSleepDuration.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSleepDuration.FlatStyle = FlatStyle.Flat;
            cmbSleepDuration.BackColor = Color.FromArgb(248, 249, 250);

            // Abitudini Alimentari
            lblDietaryHabits.Text = "Abitudini Alimentari";
            lblDietaryHabits.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDietaryHabits.ForeColor = Color.FromArgb(52, 73, 94);
            lblDietaryHabits.Location = new Point(300, 60);
            lblDietaryHabits.Size = new Size(150, 20);

            cmbDietaryHabits.Location = new Point(300, 85);
            cmbDietaryHabits.Size = new Size(180, 27);
            cmbDietaryHabits.Font = new Font("Segoe UI", 10F);
            cmbDietaryHabits.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDietaryHabits.FlatStyle = FlatStyle.Flat;
            cmbDietaryHabits.BackColor = Color.FromArgb(248, 249, 250);

            pnlLifestyle.Controls.AddRange(new Control[] {
                lblLifestyle, lblSleepDuration, cmbSleepDuration,
                lblDietaryHabits, cmbDietaryHabits
            });

            // =====================
            // SEZIONE SALUTE MENTALE
            // =====================
            pnlMentalHealth.BackColor = Color.White;
            pnlMentalHealth.Location = new Point(30, 580);
            pnlMentalHealth.Size = new Size(840, 140);
            pnlMentalHealth.BorderStyle = BorderStyle.None;
            pnlMentalHealth.Padding = new Padding(25);

            lblMentalHealth.Text = "🧘 SALUTE MENTALE";
            lblMentalHealth.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblMentalHealth.ForeColor = Color.FromArgb(155, 89, 182);
            lblMentalHealth.Location = new Point(25, 20);
            lblMentalHealth.AutoSize = true;

            // Storia Familiare
            lblFamilyHistory.Text = "Storia Familiare di Malattie Mentali";
            lblFamilyHistory.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFamilyHistory.ForeColor = Color.FromArgb(52, 73, 94);
            lblFamilyHistory.Location = new Point(35, 60);
            lblFamilyHistory.Size = new Size(220, 20);

            cmbFamilyHistory.Location = new Point(35, 85);
            cmbFamilyHistory.Size = new Size(150, 27);
            cmbFamilyHistory.Font = new Font("Segoe UI", 10F);
            cmbFamilyHistory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFamilyHistory.FlatStyle = FlatStyle.Flat;
            cmbFamilyHistory.BackColor = Color.FromArgb(248, 249, 250);

            // Pensieri Suicidi
            lblSuicidalThoughts.Text = "Pensieri Suicidi";
            lblSuicidalThoughts.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSuicidalThoughts.ForeColor = Color.FromArgb(52, 73, 94);
            lblSuicidalThoughts.Location = new Point(220, 60);
            lblSuicidalThoughts.Size = new Size(150, 20);

            cmbSuicidalThoughts.Location = new Point(220, 85);
            cmbSuicidalThoughts.Size = new Size(150, 27);
            cmbSuicidalThoughts.Font = new Font("Segoe UI", 10F);
            cmbSuicidalThoughts.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSuicidalThoughts.FlatStyle = FlatStyle.Flat;
            cmbSuicidalThoughts.BackColor = Color.FromArgb(248, 249, 250);

            pnlMentalHealth.Controls.AddRange(new Control[] {
                lblMentalHealth, lblFamilyHistory, cmbFamilyHistory,
                lblSuicidalThoughts, cmbSuicidalThoughts
            });

            // =====================
            // PANNELLO RISULTATI
            // =====================
            pnlResults.BackColor = Color.FromArgb(250, 251, 252);
            pnlResults.Location = new Point(30, 740);
            pnlResults.Size = new Size(840, 160);
            pnlResults.BorderStyle = BorderStyle.FixedSingle;
            pnlResults.Padding = new Padding(25);

            lblResult.Text = "✨ Pronto per l'analisi del rischio...";
            lblResult.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblResult.ForeColor = Color.FromArgb(52, 73, 94);
            lblResult.Location = new Point(25, 25);
            lblResult.Size = new Size(500, 35);

            lblProbability.Text = "Probabilità: --";
            lblProbability.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblProbability.ForeColor = Color.FromArgb(30, 139, 195);
            lblProbability.Location = new Point(25, 70);
            lblProbability.Size = new Size(250, 25);

            lblRiskLevel.Text = "Livello di Rischio: --";
            lblRiskLevel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRiskLevel.ForeColor = Color.FromArgb(39, 174, 96);
            lblRiskLevel.Location = new Point(300, 70);
            lblRiskLevel.Size = new Size(250, 25);

            progressRisk.Location = new Point(25, 105);
            progressRisk.Size = new Size(550, 25);
            progressRisk.Style = ProgressBarStyle.Continuous;
            progressRisk.ForeColor = Color.FromArgb(46, 204, 113);

            lblRecommendations.Text = "💡 Raccomandazioni: Completa il form per ricevere suggerimenti personalizzati";
            lblRecommendations.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            lblRecommendations.ForeColor = Color.FromArgb(127, 140, 141);
            lblRecommendations.Location = new Point(25, 135);
            lblRecommendations.Size = new Size(700, 20);

            pnlResults.Controls.AddRange(new Control[] {
                lblResult, lblProbability, lblRiskLevel, progressRisk, lblRecommendations
            });

            // =====================
            // FOOTER PANEL
            // =====================
            pnlFooter.BackColor = Color.FromArgb(44, 62, 80);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Height = 90;
            pnlFooter.Padding = new Padding(30, 20, 30, 20);

            // Bottone Analizza - Più prominente
            btnPredict.BackColor = Color.FromArgb(46, 204, 113);
            btnPredict.FlatStyle = FlatStyle.Flat;
            btnPredict.FlatAppearance.BorderSize = 0;
            btnPredict.FlatAppearance.MouseOverBackColor = Color.FromArgb(39, 174, 96);
            btnPredict.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPredict.ForeColor = Color.White;
            btnPredict.Location = new Point(30, 25);
            btnPredict.Size = new Size(200, 45);
            btnPredict.Text = "🔍 ANALIZZA RISCHIO";
            btnPredict.UseVisualStyleBackColor = false;
            btnPredict.Cursor = Cursors.Hand;
            btnPredict.Click += btnPredict_Click;

            // Bottone Dati Test
            btnTestData.BackColor = Color.FromArgb(230, 126, 34);
            // Continuazione da btnTestData
            btnTestData.FlatStyle = FlatStyle.Flat;
            btnTestData.FlatAppearance.BorderSize = 0;
            btnTestData.FlatAppearance.MouseOverBackColor = Color.FromArgb(211, 84, 0);
            btnTestData.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTestData.ForeColor = Color.White;
            btnTestData.Location = new Point(250, 25);
            btnTestData.Size = new Size(150, 45);
            btnTestData.Text = "📊 DATI TEST";
            btnTestData.UseVisualStyleBackColor = false;
            btnTestData.Cursor = Cursors.Hand;
            btnTestData.Click += btnTestData_Click;

            // Bottone Reset
            btnReset.BackColor = Color.FromArgb(231, 76, 60);
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 57, 43);
            btnReset.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(420, 25);
            btnReset.Size = new Size(130, 45);
            btnReset.Text = "🔄 RESET";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Cursor = Cursors.Hand;
            btnReset.Click += btnReset_Click;

            // Bottone Salva
            btnSave.BackColor = Color.FromArgb(52, 152, 219);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(41, 128, 185);
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(570, 25);
            btnSave.Size = new Size(130, 45);
            btnSave.Text = "💾 SALVA";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Cursor = Cursors.Hand;
           

            pnlFooter.Controls.AddRange(new Control[] {
                btnPredict, btnTestData, btnReset, btnSave
            });

            // =====================
            // AGGIUNTA CONTROLLI AL MAIN PANEL
            // =====================
            pnlMain.Controls.AddRange(new Control[] {
                pnlPersonalInfo, pnlAcademicWork, pnlLifestyle,
                pnlMentalHealth, pnlResults
            });

            // =====================
            // AGGIUNTA CONTROLLI AL FORM
            // =====================
            this.Controls.Add(pnlMain);
            this.Controls.Add(pnlSidebar);
            this.Controls.Add(pnlHeader);
            this.Controls.Add(pnlFooter);

            // =====================
            // POPOLAMENTO COMBOBOX
            // =====================
            PopulateComboBoxes();

            ResumeLayout(false);
            PerformLayout();
        }

        private void PopulateComboBoxes()
        {
            // Genere
            cmbGender.Items.AddRange(new object[] {
                "Maschio", "Femmina", "Altro", "Preferisco non specificare"
            });

            // Professione
            cmbProfession.Items.AddRange(new object[] {
                "Studente", "Ingegnere", "Medico", "Insegnante",
                "Programmatore", "Avvocato", "Ricercatore", "Designer",
                "Manager", "Consulente", "Altro"
            });

            // Titolo di Studio
            cmbDegree.Items.AddRange(new object[] {
                "Diploma", "Laurea Triennale", "Laurea Magistrale",
                "Master", "Dottorato", "Specializzazione"
            });

            // Durata del Sonno
            cmbSleepDuration.Items.AddRange(new object[] {
                "Meno di 5 ore", "5-6 ore", "6-7 ore",
                "7-8 ore", "8-9 ore", "Più di 9 ore"
            });

            // Abitudini Alimentari
            cmbDietaryHabits.Items.AddRange(new object[] {
                "Molto Sane", "Abbastanza Sane", "Moderate",
                "Poco Sane", "Molto Scarse"
            });

            // Storia Familiare
            cmbFamilyHistory.Items.AddRange(new object[] {
                "Sì", "No", "Non so"
            });

            // Pensieri Suicidi
            cmbSuicidalThoughts.Items.AddRange(new object[] {
                "Mai", "Raramente", "A volte", "Spesso", "Molto spesso"
            });

            // Imposta valori di default
            cmbGender.SelectedIndex = 0;
            cmbProfession.SelectedIndex = 0;
            cmbDegree.SelectedIndex = 0;
            cmbSleepDuration.SelectedIndex = 3; // 7-8 ore
            cmbDietaryHabits.SelectedIndex = 2; // Moderate
            cmbFamilyHistory.SelectedIndex = 1; // No
            cmbSuicidalThoughts.SelectedIndex = 0; // Mai
        }

        #endregion

        // =====================
        // DICHIARAZIONE CONTROLLI
        // =====================
        private Panel pnlHeader;
        private Panel pnlMain;
        private Panel pnlFooter;
        private Panel pnlSidebar;

        // Header controls
        private Label lblTitle;
        private Label lblSubtitle;
        private PictureBox picIcon;

        // Section panels
        private Panel pnlPersonalInfo;
        private Label lblPersonalInfo;
        private Panel pnlAcademicWork;
        private Label lblAcademicWork;
        private Panel pnlLifestyle;
        private Label lblLifestyle;
        private Panel pnlMentalHealth;
        private Label lblMentalHealth;

        // Input controls - Personal Info
        private Label lblAge;
        private TextBox txtAge;
        private Label lblGender;
        private ComboBox cmbGender;
        private Label lblCity;
        private TextBox txtCity;
        private Label lblProfession;
        private ComboBox cmbProfession;
        private Label lblDegree;
        private ComboBox cmbDegree;

        // Input controls - Academic/Work
        private Label lblCGPA;
        private TextBox txtCGPA;
        private Label lblAcademicPressure;
        private TextBox txtAcademicPressure;
        private Label lblWorkPressure;
        private TextBox txtWorkPressure;
        private Label lblWorkStudyHours;
        private TextBox txtWorkStudyHours;
        private Label lblStudySatisfaction;
        private TextBox txtStudySatisfaction;
        private Label lblJobSatisfaction;
        private TextBox txtJobSatisfaction;
        private Label lblFinancialStress;
        private TextBox txtFinancialStress;

        // Input controls - Lifestyle
        private Label lblSleepDuration;
        private ComboBox cmbSleepDuration;
        private Label lblDietaryHabits;
        private ComboBox cmbDietaryHabits;

        // Input controls - Mental Health
        private Label lblFamilyHistory;
        private ComboBox cmbFamilyHistory;
        private Label lblSuicidalThoughts;
        private ComboBox cmbSuicidalThoughts;

        // Action buttons
        private Button btnPredict;
        private Button btnTestData;
        private Button btnReset;
        private Button btnSave;

        // Results panel
        private Panel pnlResults;
        private Label lblResult;
        private Label lblProbability;
        private Label lblRiskLevel;
        private ProgressBar progressRisk;
        private Label lblRecommendations;

        // Sidebar info
        private Label lblInfo;
        private Label lblVersion;
    }
}