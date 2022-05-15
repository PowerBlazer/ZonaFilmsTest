namespace TestMovies
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuPages1 = new Bunifu.UI.WinForms.BunifuPages();
            this.MoviesPage = new System.Windows.Forms.TabPage();
            this.ListCountLabel = new System.Windows.Forms.Label();
            this.nextList = new System.Windows.Forms.PictureBox();
            this.lastList = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.searchСategoriesPanel = new System.Windows.Forms.Panel();
            this.RatingComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CountryComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.YearComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.GenresComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SettingPage = new System.Windows.Forms.TabPage();
            this.MoviesInfoPage = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.MoviesInfoPanel = new System.Windows.Forms.Panel();
            this.MenuPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.CloseApp = new System.Windows.Forms.PictureBox();
            this.logotypePicture = new System.Windows.Forms.PictureBox();
            this.SettingsButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SearchTextBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.MoviesButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuPages1.SuspendLayout();
            this.MoviesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nextList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastList)).BeginInit();
            this.panel1.SuspendLayout();
            this.searchСategoriesPanel.SuspendLayout();
            this.MoviesInfoPage.SuspendLayout();
            this.panel3.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logotypePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuPages1
            // 
            this.bunifuPages1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.bunifuPages1.AllowTransitions = true;
            this.bunifuPages1.Controls.Add(this.MoviesPage);
            this.bunifuPages1.Controls.Add(this.SettingPage);
            this.bunifuPages1.Controls.Add(this.MoviesInfoPage);
            this.bunifuPages1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPages1.Location = new System.Drawing.Point(0, 73);
            this.bunifuPages1.Multiline = true;
            this.bunifuPages1.Name = "bunifuPages1";
            this.bunifuPages1.Page = this.MoviesInfoPage;
            this.bunifuPages1.PageIndex = 2;
            this.bunifuPages1.PageName = "MoviesInfoPage";
            this.bunifuPages1.PageTitle = "tabPage1";
            this.bunifuPages1.SelectedIndex = 0;
            this.bunifuPages1.Size = new System.Drawing.Size(982, 751);
            this.bunifuPages1.TabIndex = 1;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.bunifuPages1.Transition = animation1;
            this.bunifuPages1.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Transparent;
            // 
            // MoviesPage
            // 
            this.MoviesPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.MoviesPage.Controls.Add(this.ListCountLabel);
            this.MoviesPage.Controls.Add(this.nextList);
            this.MoviesPage.Controls.Add(this.lastList);
            this.MoviesPage.Controls.Add(this.panel1);
            this.MoviesPage.Controls.Add(this.searchСategoriesPanel);
            this.MoviesPage.Location = new System.Drawing.Point(4, 4);
            this.MoviesPage.Name = "MoviesPage";
            this.MoviesPage.Padding = new System.Windows.Forms.Padding(3);
            this.MoviesPage.Size = new System.Drawing.Size(974, 725);
            this.MoviesPage.TabIndex = 0;
            this.MoviesPage.Text = "tabPage1";
            // 
            // ListCountLabel
            // 
            this.ListCountLabel.AutoSize = true;
            this.ListCountLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListCountLabel.ForeColor = System.Drawing.Color.White;
            this.ListCountLabel.Location = new System.Drawing.Point(50, 690);
            this.ListCountLabel.Name = "ListCountLabel";
            this.ListCountLabel.Size = new System.Drawing.Size(102, 25);
            this.ListCountLabel.TabIndex = 4;
            this.ListCountLabel.Text = " Страница";
            // 
            // nextList
            // 
            this.nextList.Image = global::TestMovies.Properties.Resources.arrowpointingleft_87473__1__EjQwm;
            this.nextList.Location = new System.Drawing.Point(928, 684);
            this.nextList.Name = "nextList";
            this.nextList.Size = new System.Drawing.Size(41, 36);
            this.nextList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.nextList.TabIndex = 3;
            this.nextList.TabStop = false;
            this.nextList.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lastList
            // 
            this.lastList.Image = global::TestMovies.Properties.Resources.arrowpointingleft_87473__1_1;
            this.lastList.Location = new System.Drawing.Point(2, 684);
            this.lastList.Name = "lastList";
            this.lastList.Size = new System.Drawing.Size(41, 36);
            this.lastList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lastList.TabIndex = 1;
            this.lastList.TabStop = false;
            this.lastList.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 637);
            this.panel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(966, 635);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // searchСategoriesPanel
            // 
            this.searchСategoriesPanel.Controls.Add(this.RatingComboBox);
            this.searchСategoriesPanel.Controls.Add(this.CountryComboBox);
            this.searchСategoriesPanel.Controls.Add(this.YearComboBox);
            this.searchСategoriesPanel.Controls.Add(this.GenresComboBox);
            this.searchСategoriesPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchСategoriesPanel.Location = new System.Drawing.Point(3, 3);
            this.searchСategoriesPanel.Name = "searchСategoriesPanel";
            this.searchСategoriesPanel.Size = new System.Drawing.Size(968, 38);
            this.searchСategoriesPanel.TabIndex = 0;
            // 
            // RatingComboBox
            // 
            this.RatingComboBox.AutoRoundedCorners = true;
            this.RatingComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.RatingComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RatingComboBox.BorderRadius = 17;
            this.RatingComboBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.RatingComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.RatingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RatingComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.RatingComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RatingComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RatingComboBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.RatingComboBox.ForeColor = System.Drawing.Color.White;
            this.RatingComboBox.ItemHeight = 30;
            this.RatingComboBox.Items.AddRange(new object[] {
            "Рейтинг",
            "0-3",
            "3-5",
            "5-8",
            "8-10"});
            this.RatingComboBox.Location = new System.Drawing.Point(471, 0);
            this.RatingComboBox.Name = "RatingComboBox";
            this.RatingComboBox.Size = new System.Drawing.Size(159, 36);
            this.RatingComboBox.TabIndex = 6;
            // 
            // CountryComboBox
            // 
            this.CountryComboBox.AutoRoundedCorners = true;
            this.CountryComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.CountryComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CountryComboBox.BorderRadius = 17;
            this.CountryComboBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.CountryComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CountryComboBox.DropDownHeight = 400;
            this.CountryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CountryComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.CountryComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CountryComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CountryComboBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CountryComboBox.ForeColor = System.Drawing.Color.White;
            this.CountryComboBox.IntegralHeight = false;
            this.CountryComboBox.ItemHeight = 30;
            this.CountryComboBox.Items.AddRange(new object[] {
            "Страна",
            "США",
            "Россия",
            "Франция",
            "Великобритания",
            "Италия",
            "Германия",
            "Канада",
            "Индия",
            "Япония",
            "Испания",
            "Гонконг",
            "Корея-Южная",
            "Китай",
            "Австралия",
            "Бельгия",
            "Швеция",
            "Польша",
            "Дания",
            "Мексика",
            "Чехия",
            "Нидерланды",
            "Украина",
            "Ирландия",
            "Норвегия",
            "Швейцария",
            "Аргентина",
            "Венгрия",
            "Австрия",
            "Сербия",
            "Таиланд"});
            this.CountryComboBox.Location = new System.Drawing.Point(312, 0);
            this.CountryComboBox.Name = "CountryComboBox";
            this.CountryComboBox.Size = new System.Drawing.Size(159, 36);
            this.CountryComboBox.TabIndex = 4;
            this.CountryComboBox.SelectedIndexChanged += new System.EventHandler(this.CountryComboBox_SelectedIndexChanged);
            // 
            // YearComboBox
            // 
            this.YearComboBox.AutoRoundedCorners = true;
            this.YearComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.YearComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.YearComboBox.BorderRadius = 17;
            this.YearComboBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.YearComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.YearComboBox.DropDownHeight = 400;
            this.YearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.YearComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.YearComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.YearComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.YearComboBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.YearComboBox.ForeColor = System.Drawing.Color.White;
            this.YearComboBox.IntegralHeight = false;
            this.YearComboBox.ItemHeight = 30;
            this.YearComboBox.Items.AddRange(new object[] {
            "Год",
            "2022",
            "2021",
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000"});
            this.YearComboBox.Location = new System.Drawing.Point(176, 0);
            this.YearComboBox.Name = "YearComboBox";
            this.YearComboBox.Size = new System.Drawing.Size(136, 36);
            this.YearComboBox.TabIndex = 2;
            this.YearComboBox.SelectedIndexChanged += new System.EventHandler(this.YearComboBox_SelectedIndexChanged);
            // 
            // GenresComboBox
            // 
            this.GenresComboBox.AutoRoundedCorners = true;
            this.GenresComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.GenresComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GenresComboBox.BorderRadius = 17;
            this.GenresComboBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.GenresComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.GenresComboBox.DropDownHeight = 400;
            this.GenresComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenresComboBox.DropDownWidth = 159;
            this.GenresComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.GenresComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GenresComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GenresComboBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.GenresComboBox.ForeColor = System.Drawing.Color.White;
            this.GenresComboBox.IntegralHeight = false;
            this.GenresComboBox.ItemHeight = 30;
            this.GenresComboBox.Items.AddRange(new object[] {
            "Жанры",
            "драма",
            "комедия",
            "триллер",
            "мелодрама",
            "боевик",
            "криминал",
            "ужасы",
            "приключения",
            "фантастика",
            "детектив",
            "фэнтэзи",
            "семейный",
            "мультфильм",
            "военный",
            "история",
            "биография",
            "мюзикл",
            "вестерн",
            "короткометражка",
            "музыка",
            "спорт",
            "документальный",
            "аниме",
            "детский",
            "фильм-нуар",
            "реальное ТВ",
            "новости",
            "ток-шоу",
            "концерт",
            "игра"});
            this.GenresComboBox.Location = new System.Drawing.Point(0, 0);
            this.GenresComboBox.Name = "GenresComboBox";
            this.GenresComboBox.Size = new System.Drawing.Size(176, 36);
            this.GenresComboBox.TabIndex = 0;
            this.GenresComboBox.SelectedIndexChanged += new System.EventHandler(this.GenresComboBox_SelectedIndexChanged);
            // 
            // SettingPage
            // 
            this.SettingPage.Location = new System.Drawing.Point(4, 4);
            this.SettingPage.Name = "SettingPage";
            this.SettingPage.Padding = new System.Windows.Forms.Padding(3);
            this.SettingPage.Size = new System.Drawing.Size(974, 725);
            this.SettingPage.TabIndex = 1;
            this.SettingPage.Text = "SettingsPage";
            this.SettingPage.UseVisualStyleBackColor = true;
            // 
            // MoviesInfoPage
            // 
            this.MoviesInfoPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.MoviesInfoPage.Controls.Add(this.panel3);
            this.MoviesInfoPage.Controls.Add(this.MoviesInfoPanel);
            this.MoviesInfoPage.Location = new System.Drawing.Point(4, 4);
            this.MoviesInfoPage.Name = "MoviesInfoPage";
            this.MoviesInfoPage.Size = new System.Drawing.Size(974, 725);
            this.MoviesInfoPage.TabIndex = 2;
            this.MoviesInfoPage.Text = "tabPage1";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bunifuButton1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(974, 43);
            this.panel3.TabIndex = 0;
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.AllowAnimations = true;
            this.bunifuButton1.AllowMouseEffects = true;
            this.bunifuButton1.AllowToggling = false;
            this.bunifuButton1.AnimationSpeed = 200;
            this.bunifuButton1.AutoGenerateColors = false;
            this.bunifuButton1.AutoRoundBorders = false;
            this.bunifuButton1.AutoSizeLeftIcon = true;
            this.bunifuButton1.AutoSizeRightIcon = true;
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.ButtonText = "Назад";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.ColorContrastOnClick = 45;
            this.bunifuButton1.ColorContrastOnHover = 45;
            this.bunifuButton1.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bunifuButton1.CustomizableEdges = borderEdges1;
            this.bunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.bunifuButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton1.IconMarginLeft = 11;
            this.bunifuButton1.IconPadding = 10;
            this.bunifuButton1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton1.IconSize = 25;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.bunifuButton1.IdleBorderRadius = 1;
            this.bunifuButton1.IdleBorderThickness = 1;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.bunifuButton1.IdleIconLeftImage = global::TestMovies.Properties.Resources.arrowpointingleft_87473__1_;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.IndicateFocus = false;
            this.bunifuButton1.Location = new System.Drawing.Point(0, 0);
            this.bunifuButton1.Name = "bunifuButton1";
            this.bunifuButton1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.OnDisabledState.BorderRadius = 1;
            this.bunifuButton1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnDisabledState.BorderThickness = 1;
            this.bunifuButton1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.OnDisabledState.IconLeftImage = null;
            this.bunifuButton1.OnDisabledState.IconRightImage = null;
            this.bunifuButton1.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton1.onHoverState.BorderRadius = 1;
            this.bunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.onHoverState.BorderThickness = 1;
            this.bunifuButton1.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton1.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.onHoverState.IconLeftImage = null;
            this.bunifuButton1.onHoverState.IconRightImage = null;
            this.bunifuButton1.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.bunifuButton1.OnIdleState.BorderRadius = 1;
            this.bunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnIdleState.BorderThickness = 1;
            this.bunifuButton1.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.bunifuButton1.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnIdleState.IconLeftImage = global::TestMovies.Properties.Resources.arrowpointingleft_87473__1_;
            this.bunifuButton1.OnIdleState.IconRightImage = null;
            this.bunifuButton1.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton1.OnPressedState.BorderRadius = 1;
            this.bunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnPressedState.BorderThickness = 1;
            this.bunifuButton1.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton1.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnPressedState.IconLeftImage = null;
            this.bunifuButton1.OnPressedState.IconRightImage = null;
            this.bunifuButton1.Size = new System.Drawing.Size(151, 43);
            this.bunifuButton1.TabIndex = 0;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton1.TextMarginLeft = 0;
            this.bunifuButton1.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
            this.bunifuButton1.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // MoviesInfoPanel
            // 
            this.MoviesInfoPanel.Location = new System.Drawing.Point(0, 49);
            this.MoviesInfoPanel.Name = "MoviesInfoPanel";
            this.MoviesInfoPanel.Size = new System.Drawing.Size(974, 676);
            this.MoviesInfoPanel.TabIndex = 0;
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(120)))));
            this.MenuPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MenuPanel.BackgroundImage")));
            this.MenuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(120)))));
            this.MenuPanel.BorderRadius = 0;
            this.MenuPanel.BorderThickness = 1;
            this.MenuPanel.Controls.Add(this.CloseApp);
            this.MenuPanel.Controls.Add(this.logotypePicture);
            this.MenuPanel.Controls.Add(this.SettingsButton);
            this.MenuPanel.Controls.Add(this.SearchTextBox);
            this.MenuPanel.Controls.Add(this.MoviesButton);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.ShowBorders = true;
            this.MenuPanel.Size = new System.Drawing.Size(982, 73);
            this.MenuPanel.TabIndex = 0;
            this.MenuPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuPanel_MouseDown);
            this.MenuPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MenuPanel_MouseMove);
            // 
            // CloseApp
            // 
            this.CloseApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(120)))));
            this.CloseApp.Image = global::TestMovies.Properties.Resources.premium_icon_close_4013407__1_;
            this.CloseApp.Location = new System.Drawing.Point(925, 14);
            this.CloseApp.Name = "CloseApp";
            this.CloseApp.Size = new System.Drawing.Size(48, 44);
            this.CloseApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseApp.TabIndex = 4;
            this.CloseApp.TabStop = false;
            this.CloseApp.Click += new System.EventHandler(this.CloseApp_Click);
            // 
            // logotypePicture
            // 
            this.logotypePicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(120)))));
            this.logotypePicture.Image = global::TestMovies.Properties.Resources.zona;
            this.logotypePicture.Location = new System.Drawing.Point(28, 14);
            this.logotypePicture.Name = "logotypePicture";
            this.logotypePicture.Size = new System.Drawing.Size(138, 50);
            this.logotypePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logotypePicture.TabIndex = 0;
            this.logotypePicture.TabStop = false;
            // 
            // SettingsButton
            // 
            this.SettingsButton.AllowAnimations = true;
            this.SettingsButton.AllowMouseEffects = true;
            this.SettingsButton.AllowToggling = false;
            this.SettingsButton.AnimationSpeed = 200;
            this.SettingsButton.AutoGenerateColors = false;
            this.SettingsButton.AutoRoundBorders = false;
            this.SettingsButton.AutoSizeLeftIcon = true;
            this.SettingsButton.AutoSizeRightIcon = true;
            this.SettingsButton.BackColor = System.Drawing.Color.Transparent;
            this.SettingsButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(120)))));
            this.SettingsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SettingsButton.BackgroundImage")));
            this.SettingsButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SettingsButton.ButtonText = "Настройки";
            this.SettingsButton.ButtonTextMarginLeft = 0;
            this.SettingsButton.ColorContrastOnClick = 45;
            this.SettingsButton.ColorContrastOnHover = 45;
            this.SettingsButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.SettingsButton.CustomizableEdges = borderEdges2;
            this.SettingsButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SettingsButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(120)))));
            this.SettingsButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(120)))));
            this.SettingsButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.SettingsButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.SettingsButton.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.SettingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.SettingsButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.SettingsButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.SettingsButton.IconMarginLeft = 11;
            this.SettingsButton.IconPadding = 10;
            this.SettingsButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SettingsButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.SettingsButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.SettingsButton.IconSize = 25;
            this.SettingsButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(120)))));
            this.SettingsButton.IdleBorderRadius = 1;
            this.SettingsButton.IdleBorderThickness = 1;
            this.SettingsButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(120)))));
            this.SettingsButton.IdleIconLeftImage = null;
            this.SettingsButton.IdleIconRightImage = null;
            this.SettingsButton.IndicateFocus = false;
            this.SettingsButton.Location = new System.Drawing.Point(331, 20);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(120)))));
            this.SettingsButton.OnDisabledState.BorderRadius = 1;
            this.SettingsButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SettingsButton.OnDisabledState.BorderThickness = 1;
            this.SettingsButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(120)))));
            this.SettingsButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.SettingsButton.OnDisabledState.IconLeftImage = null;
            this.SettingsButton.OnDisabledState.IconRightImage = null;
            this.SettingsButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(120)))));
            this.SettingsButton.onHoverState.BorderRadius = 1;
            this.SettingsButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SettingsButton.onHoverState.BorderThickness = 1;
            this.SettingsButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(120)))));
            this.SettingsButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.SettingsButton.onHoverState.IconLeftImage = null;
            this.SettingsButton.onHoverState.IconRightImage = null;
            this.SettingsButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(120)))));
            this.SettingsButton.OnIdleState.BorderRadius = 1;
            this.SettingsButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SettingsButton.OnIdleState.BorderThickness = 1;
            this.SettingsButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(120)))));
            this.SettingsButton.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.SettingsButton.OnIdleState.IconLeftImage = null;
            this.SettingsButton.OnIdleState.IconRightImage = null;
            this.SettingsButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(120)))));
            this.SettingsButton.OnPressedState.BorderRadius = 1;
            this.SettingsButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SettingsButton.OnPressedState.BorderThickness = 1;
            this.SettingsButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(120)))));
            this.SettingsButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.SettingsButton.OnPressedState.IconLeftImage = null;
            this.SettingsButton.OnPressedState.IconRightImage = null;
            this.SettingsButton.Size = new System.Drawing.Size(121, 39);
            this.SettingsButton.TabIndex = 3;
            this.SettingsButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.SettingsButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.SettingsButton.TextMarginLeft = 0;
            this.SettingsButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.SettingsButton.UseDefaultRadiusAndThickness = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.AcceptsReturn = false;
            this.SearchTextBox.AcceptsTab = false;
            this.SearchTextBox.AnimationSpeed = 200;
            this.SearchTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.SearchTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.SearchTextBox.BackColor = System.Drawing.Color.Transparent;
            this.SearchTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchTextBox.BackgroundImage")));
            this.SearchTextBox.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.SearchTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SearchTextBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.SearchTextBox.BorderColorIdle = System.Drawing.Color.Silver;
            this.SearchTextBox.BorderRadius = 1;
            this.SearchTextBox.BorderThickness = 1;
            this.SearchTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.SearchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchTextBox.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.SearchTextBox.DefaultText = "";
            this.SearchTextBox.FillColor = System.Drawing.Color.White;
            this.SearchTextBox.HideSelection = true;
            this.SearchTextBox.IconLeft = null;
            this.SearchTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchTextBox.IconPadding = 10;
            this.SearchTextBox.IconRight = null;
            this.SearchTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchTextBox.Lines = new string[0];
            this.SearchTextBox.Location = new System.Drawing.Point(622, 14);
            this.SearchTextBox.MaxLength = 32767;
            this.SearchTextBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.SearchTextBox.Modified = false;
            this.SearchTextBox.Multiline = false;
            this.SearchTextBox.Name = "SearchTextBox";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.SearchTextBox.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.SearchTextBox.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.SearchTextBox.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.SearchTextBox.OnIdleState = stateProperties4;
            this.SearchTextBox.Padding = new System.Windows.Forms.Padding(3);
            this.SearchTextBox.PasswordChar = '\0';
            this.SearchTextBox.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.SearchTextBox.PlaceholderText = "Поиск Фильмов";
            this.SearchTextBox.ReadOnly = false;
            this.SearchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SearchTextBox.SelectedText = "";
            this.SearchTextBox.SelectionLength = 0;
            this.SearchTextBox.SelectionStart = 0;
            this.SearchTextBox.ShortcutsEnabled = true;
            this.SearchTextBox.Size = new System.Drawing.Size(285, 44);
            this.SearchTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.SearchTextBox.TabIndex = 2;
            this.SearchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SearchTextBox.TextMarginBottom = 0;
            this.SearchTextBox.TextMarginLeft = 3;
            this.SearchTextBox.TextMarginTop = 0;
            this.SearchTextBox.TextPlaceholder = "Поиск Фильмов";
            this.SearchTextBox.UseSystemPasswordChar = false;
            this.SearchTextBox.WordWrap = true;
            this.SearchTextBox.TextChange += new System.EventHandler(this.SearchTextBox_TextChange);
            this.SearchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchTextBox_KeyDown);
            // 
            // MoviesButton
            // 
            this.MoviesButton.AllowAnimations = true;
            this.MoviesButton.AllowMouseEffects = true;
            this.MoviesButton.AllowToggling = false;
            this.MoviesButton.AnimationSpeed = 200;
            this.MoviesButton.AutoGenerateColors = false;
            this.MoviesButton.AutoRoundBorders = false;
            this.MoviesButton.AutoSizeLeftIcon = true;
            this.MoviesButton.AutoSizeRightIcon = true;
            this.MoviesButton.BackColor = System.Drawing.Color.Transparent;
            this.MoviesButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(120)))));
            this.MoviesButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MoviesButton.BackgroundImage")));
            this.MoviesButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.MoviesButton.ButtonText = "Фильмы";
            this.MoviesButton.ButtonTextMarginLeft = 0;
            this.MoviesButton.ColorContrastOnClick = 45;
            this.MoviesButton.ColorContrastOnHover = 45;
            this.MoviesButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.MoviesButton.CustomizableEdges = borderEdges3;
            this.MoviesButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.MoviesButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(120)))));
            this.MoviesButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(120)))));
            this.MoviesButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.MoviesButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.MoviesButton.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.MoviesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.MoviesButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MoviesButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.MoviesButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.MoviesButton.IconMarginLeft = 11;
            this.MoviesButton.IconPadding = 10;
            this.MoviesButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MoviesButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.MoviesButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.MoviesButton.IconSize = 25;
            this.MoviesButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(120)))));
            this.MoviesButton.IdleBorderRadius = 1;
            this.MoviesButton.IdleBorderThickness = 1;
            this.MoviesButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(120)))));
            this.MoviesButton.IdleIconLeftImage = null;
            this.MoviesButton.IdleIconRightImage = null;
            this.MoviesButton.IndicateFocus = false;
            this.MoviesButton.Location = new System.Drawing.Point(195, 20);
            this.MoviesButton.Name = "MoviesButton";
            this.MoviesButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(120)))));
            this.MoviesButton.OnDisabledState.BorderRadius = 1;
            this.MoviesButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.MoviesButton.OnDisabledState.BorderThickness = 1;
            this.MoviesButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(120)))));
            this.MoviesButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.MoviesButton.OnDisabledState.IconLeftImage = null;
            this.MoviesButton.OnDisabledState.IconRightImage = null;
            this.MoviesButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(120)))));
            this.MoviesButton.onHoverState.BorderRadius = 1;
            this.MoviesButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.MoviesButton.onHoverState.BorderThickness = 1;
            this.MoviesButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(120)))));
            this.MoviesButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.MoviesButton.onHoverState.IconLeftImage = null;
            this.MoviesButton.onHoverState.IconRightImage = null;
            this.MoviesButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(120)))));
            this.MoviesButton.OnIdleState.BorderRadius = 1;
            this.MoviesButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.MoviesButton.OnIdleState.BorderThickness = 1;
            this.MoviesButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(120)))));
            this.MoviesButton.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.MoviesButton.OnIdleState.IconLeftImage = null;
            this.MoviesButton.OnIdleState.IconRightImage = null;
            this.MoviesButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(120)))));
            this.MoviesButton.OnPressedState.BorderRadius = 1;
            this.MoviesButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.MoviesButton.OnPressedState.BorderThickness = 1;
            this.MoviesButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(120)))));
            this.MoviesButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.MoviesButton.OnPressedState.IconLeftImage = null;
            this.MoviesButton.OnPressedState.IconRightImage = null;
            this.MoviesButton.Size = new System.Drawing.Size(95, 39);
            this.MoviesButton.TabIndex = 0;
            this.MoviesButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.MoviesButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.MoviesButton.TextMarginLeft = 0;
            this.MoviesButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.MoviesButton.UseDefaultRadiusAndThickness = true;
            this.MoviesButton.Click += new System.EventHandler(this.MoviesButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 824);
            this.Controls.Add(this.bunifuPages1);
            this.Controls.Add(this.MenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Leave += new System.EventHandler(this.Form1_Leave);
            this.bunifuPages1.ResumeLayout(false);
            this.MoviesPage.ResumeLayout(false);
            this.MoviesPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nextList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.searchСategoriesPanel.ResumeLayout(false);
            this.MoviesInfoPage.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.MenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CloseApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logotypePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel MenuPanel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton MoviesButton;
        private Bunifu.UI.WinForms.BunifuPages bunifuPages1;
        private System.Windows.Forms.TabPage MoviesPage;
        private System.Windows.Forms.TabPage SettingPage;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton SettingsButton;
        private Bunifu.UI.WinForms.BunifuTextBox SearchTextBox;
        private System.Windows.Forms.PictureBox logotypePicture;
        private System.Windows.Forms.PictureBox CloseApp;
        private System.Windows.Forms.Panel searchСategoriesPanel;
        private Guna.UI2.WinForms.Guna2ComboBox GenresComboBox;
        private Guna.UI2.WinForms.Guna2ComboBox YearComboBox;
        private Guna.UI2.WinForms.Guna2ComboBox CountryComboBox;
        private Guna.UI2.WinForms.Guna2ComboBox RatingComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox lastList;
        private System.Windows.Forms.PictureBox nextList;
        private System.Windows.Forms.Label ListCountLabel;
        private System.Windows.Forms.TabPage MoviesInfoPage;
        private System.Windows.Forms.Panel MoviesInfoPanel;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
    }
}

