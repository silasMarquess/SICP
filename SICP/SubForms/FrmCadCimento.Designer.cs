
namespace SICP.SubForms
{
    partial class FrmCadCimento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadCimento));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.btn_EditarDados = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Lb_ValLucro = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuSeparator2 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.lb_codigoMat = new Bunifu.UI.WinForms.BunifuLabel();
            this.btn_FecharJanela = new System.Windows.Forms.Button();
            this.btn_CadastrarMarca = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.NumUp_ValorVenda = new System.Windows.Forms.NumericUpDown();
            this.bunifuLabel6 = new Bunifu.UI.WinForms.BunifuLabel();
            this.NumUp_PerLucro = new System.Windows.Forms.NumericUpDown();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.NumUp_ValorCusto = new System.Windows.Forms.NumericUpDown();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txt_NomeMarcaCimento = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.button3 = new System.Windows.Forms.Button();
            this.LB_Operacao = new Bunifu.UI.WinForms.BunifuLabel();
            this.NumUp_EstoqueInicial = new System.Windows.Forms.NumericUpDown();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUp_ValorVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUp_PerLucro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUp_ValorCusto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUp_EstoqueInicial)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Turquoise;
            this.bunifuCards1.Controls.Add(this.NumUp_EstoqueInicial);
            this.bunifuCards1.Controls.Add(this.btn_EditarDados);
            this.bunifuCards1.Controls.Add(this.Lb_ValLucro);
            this.bunifuCards1.Controls.Add(this.bunifuSeparator2);
            this.bunifuCards1.Controls.Add(this.lb_codigoMat);
            this.bunifuCards1.Controls.Add(this.btn_FecharJanela);
            this.bunifuCards1.Controls.Add(this.btn_CadastrarMarca);
            this.bunifuCards1.Controls.Add(this.NumUp_ValorVenda);
            this.bunifuCards1.Controls.Add(this.bunifuLabel6);
            this.bunifuCards1.Controls.Add(this.NumUp_PerLucro);
            this.bunifuCards1.Controls.Add(this.bunifuLabel5);
            this.bunifuCards1.Controls.Add(this.NumUp_ValorCusto);
            this.bunifuCards1.Controls.Add(this.bunifuLabel4);
            this.bunifuCards1.Controls.Add(this.bunifuLabel3);
            this.bunifuCards1.Controls.Add(this.txt_NomeMarcaCimento);
            this.bunifuCards1.Controls.Add(this.bunifuLabel2);
            this.bunifuCards1.Controls.Add(this.bunifuSeparator1);
            this.bunifuCards1.Controls.Add(this.button3);
            this.bunifuCards1.Controls.Add(this.LB_Operacao);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(558, 342);
            this.bunifuCards1.TabIndex = 1;
            this.bunifuCards1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuCards1_Paint);
            // 
            // btn_EditarDados
            // 
            this.btn_EditarDados.AllowAnimations = true;
            this.btn_EditarDados.AllowMouseEffects = true;
            this.btn_EditarDados.AllowToggling = false;
            this.btn_EditarDados.AnimationSpeed = 200;
            this.btn_EditarDados.AutoGenerateColors = false;
            this.btn_EditarDados.AutoRoundBorders = false;
            this.btn_EditarDados.AutoSizeLeftIcon = true;
            this.btn_EditarDados.AutoSizeRightIcon = true;
            this.btn_EditarDados.BackColor = System.Drawing.Color.Transparent;
            this.btn_EditarDados.BackColor1 = System.Drawing.Color.Gray;
            this.btn_EditarDados.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_EditarDados.BackgroundImage")));
            this.btn_EditarDados.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_EditarDados.ButtonText = "ATUALIZAR DADOS";
            this.btn_EditarDados.ButtonTextMarginLeft = 0;
            this.btn_EditarDados.ColorContrastOnClick = 45;
            this.btn_EditarDados.ColorContrastOnHover = 45;
            this.btn_EditarDados.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_EditarDados.CustomizableEdges = borderEdges1;
            this.btn_EditarDados.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_EditarDados.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_EditarDados.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_EditarDados.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_EditarDados.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_EditarDados.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_EditarDados.ForeColor = System.Drawing.Color.White;
            this.btn_EditarDados.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EditarDados.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_EditarDados.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_EditarDados.IconMarginLeft = 11;
            this.btn_EditarDados.IconPadding = 10;
            this.btn_EditarDados.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_EditarDados.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_EditarDados.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_EditarDados.IconSize = 25;
            this.btn_EditarDados.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btn_EditarDados.IdleBorderRadius = 1;
            this.btn_EditarDados.IdleBorderThickness = 1;
            this.btn_EditarDados.IdleFillColor = System.Drawing.Color.Gray;
            this.btn_EditarDados.IdleIconLeftImage = null;
            this.btn_EditarDados.IdleIconRightImage = null;
            this.btn_EditarDados.IndicateFocus = false;
            this.btn_EditarDados.Location = new System.Drawing.Point(400, 285);
            this.btn_EditarDados.Name = "btn_EditarDados";
            this.btn_EditarDados.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_EditarDados.OnDisabledState.BorderRadius = 1;
            this.btn_EditarDados.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_EditarDados.OnDisabledState.BorderThickness = 1;
            this.btn_EditarDados.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_EditarDados.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_EditarDados.OnDisabledState.IconLeftImage = null;
            this.btn_EditarDados.OnDisabledState.IconRightImage = null;
            this.btn_EditarDados.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_EditarDados.onHoverState.BorderRadius = 1;
            this.btn_EditarDados.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_EditarDados.onHoverState.BorderThickness = 1;
            this.btn_EditarDados.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_EditarDados.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_EditarDados.onHoverState.IconLeftImage = null;
            this.btn_EditarDados.onHoverState.IconRightImage = null;
            this.btn_EditarDados.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_EditarDados.OnIdleState.BorderRadius = 1;
            this.btn_EditarDados.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_EditarDados.OnIdleState.BorderThickness = 1;
            this.btn_EditarDados.OnIdleState.FillColor = System.Drawing.Color.Gray;
            this.btn_EditarDados.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_EditarDados.OnIdleState.IconLeftImage = null;
            this.btn_EditarDados.OnIdleState.IconRightImage = null;
            this.btn_EditarDados.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_EditarDados.OnPressedState.BorderRadius = 1;
            this.btn_EditarDados.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_EditarDados.OnPressedState.BorderThickness = 1;
            this.btn_EditarDados.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_EditarDados.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_EditarDados.OnPressedState.IconLeftImage = null;
            this.btn_EditarDados.OnPressedState.IconRightImage = null;
            this.btn_EditarDados.Size = new System.Drawing.Size(144, 36);
            this.btn_EditarDados.TabIndex = 27;
            this.btn_EditarDados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_EditarDados.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_EditarDados.TextMarginLeft = 0;
            this.btn_EditarDados.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_EditarDados.UseDefaultRadiusAndThickness = true;
            this.btn_EditarDados.Click += new System.EventHandler(this.btn_EditarDados_Click);
            // 
            // Lb_ValLucro
            // 
            this.Lb_ValLucro.AllowParentOverrides = false;
            this.Lb_ValLucro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lb_ValLucro.AutoEllipsis = false;
            this.Lb_ValLucro.BackColor = System.Drawing.SystemColors.Info;
            this.Lb_ValLucro.CursorType = null;
            this.Lb_ValLucro.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.Lb_ValLucro.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Lb_ValLucro.Location = new System.Drawing.Point(269, 225);
            this.Lb_ValLucro.Name = "Lb_ValLucro";
            this.Lb_ValLucro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lb_ValLucro.Size = new System.Drawing.Size(24, 25);
            this.Lb_ValLucro.TabIndex = 26;
            this.Lb_ValLucro.Text = "---";
            this.Lb_ValLucro.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.Lb_ValLucro.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator2.BackgroundImage")));
            this.bunifuSeparator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator2.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator2.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(197, 15);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Vertical;
            this.bunifuSeparator2.Size = new System.Drawing.Size(14, 30);
            this.bunifuSeparator2.TabIndex = 25;
            // 
            // lb_codigoMat
            // 
            this.lb_codigoMat.AllowParentOverrides = false;
            this.lb_codigoMat.AutoEllipsis = false;
            this.lb_codigoMat.CursorType = null;
            this.lb_codigoMat.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lb_codigoMat.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_codigoMat.Location = new System.Drawing.Point(214, 15);
            this.lb_codigoMat.Name = "lb_codigoMat";
            this.lb_codigoMat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_codigoMat.Size = new System.Drawing.Size(81, 30);
            this.lb_codigoMat.TabIndex = 24;
            this.lb_codigoMat.Text = "MC0000";
            this.lb_codigoMat.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lb_codigoMat.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btn_FecharJanela
            // 
            this.btn_FecharJanela.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_FecharJanela.FlatAppearance.BorderSize = 0;
            this.btn_FecharJanela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FecharJanela.Image = global::SICP.Properties.Resources.FECHA;
            this.btn_FecharJanela.Location = new System.Drawing.Point(488, 5);
            this.btn_FecharJanela.Name = "btn_FecharJanela";
            this.btn_FecharJanela.Size = new System.Drawing.Size(56, 50);
            this.btn_FecharJanela.TabIndex = 22;
            this.btn_FecharJanela.UseVisualStyleBackColor = true;
            this.btn_FecharJanela.Click += new System.EventHandler(this.btn_FecharJanela_Click);
            // 
            // btn_CadastrarMarca
            // 
            this.btn_CadastrarMarca.AllowAnimations = true;
            this.btn_CadastrarMarca.AllowMouseEffects = true;
            this.btn_CadastrarMarca.AllowToggling = false;
            this.btn_CadastrarMarca.AnimationSpeed = 200;
            this.btn_CadastrarMarca.AutoGenerateColors = false;
            this.btn_CadastrarMarca.AutoRoundBorders = false;
            this.btn_CadastrarMarca.AutoSizeLeftIcon = true;
            this.btn_CadastrarMarca.AutoSizeRightIcon = true;
            this.btn_CadastrarMarca.BackColor = System.Drawing.Color.Transparent;
            this.btn_CadastrarMarca.BackColor1 = System.Drawing.Color.Gray;
            this.btn_CadastrarMarca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_CadastrarMarca.BackgroundImage")));
            this.btn_CadastrarMarca.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_CadastrarMarca.ButtonText = "CADASTRAR MARCA";
            this.btn_CadastrarMarca.ButtonTextMarginLeft = 0;
            this.btn_CadastrarMarca.ColorContrastOnClick = 45;
            this.btn_CadastrarMarca.ColorContrastOnHover = 45;
            this.btn_CadastrarMarca.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btn_CadastrarMarca.CustomizableEdges = borderEdges2;
            this.btn_CadastrarMarca.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_CadastrarMarca.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_CadastrarMarca.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_CadastrarMarca.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_CadastrarMarca.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_CadastrarMarca.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_CadastrarMarca.ForeColor = System.Drawing.Color.White;
            this.btn_CadastrarMarca.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CadastrarMarca.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_CadastrarMarca.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_CadastrarMarca.IconMarginLeft = 11;
            this.btn_CadastrarMarca.IconPadding = 10;
            this.btn_CadastrarMarca.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CadastrarMarca.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_CadastrarMarca.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_CadastrarMarca.IconSize = 25;
            this.btn_CadastrarMarca.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btn_CadastrarMarca.IdleBorderRadius = 1;
            this.btn_CadastrarMarca.IdleBorderThickness = 1;
            this.btn_CadastrarMarca.IdleFillColor = System.Drawing.Color.Gray;
            this.btn_CadastrarMarca.IdleIconLeftImage = null;
            this.btn_CadastrarMarca.IdleIconRightImage = null;
            this.btn_CadastrarMarca.IndicateFocus = false;
            this.btn_CadastrarMarca.Location = new System.Drawing.Point(15, 285);
            this.btn_CadastrarMarca.Name = "btn_CadastrarMarca";
            this.btn_CadastrarMarca.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_CadastrarMarca.OnDisabledState.BorderRadius = 1;
            this.btn_CadastrarMarca.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_CadastrarMarca.OnDisabledState.BorderThickness = 1;
            this.btn_CadastrarMarca.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_CadastrarMarca.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_CadastrarMarca.OnDisabledState.IconLeftImage = null;
            this.btn_CadastrarMarca.OnDisabledState.IconRightImage = null;
            this.btn_CadastrarMarca.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_CadastrarMarca.onHoverState.BorderRadius = 1;
            this.btn_CadastrarMarca.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_CadastrarMarca.onHoverState.BorderThickness = 1;
            this.btn_CadastrarMarca.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_CadastrarMarca.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_CadastrarMarca.onHoverState.IconLeftImage = null;
            this.btn_CadastrarMarca.onHoverState.IconRightImage = null;
            this.btn_CadastrarMarca.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_CadastrarMarca.OnIdleState.BorderRadius = 1;
            this.btn_CadastrarMarca.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_CadastrarMarca.OnIdleState.BorderThickness = 1;
            this.btn_CadastrarMarca.OnIdleState.FillColor = System.Drawing.Color.Gray;
            this.btn_CadastrarMarca.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_CadastrarMarca.OnIdleState.IconLeftImage = null;
            this.btn_CadastrarMarca.OnIdleState.IconRightImage = null;
            this.btn_CadastrarMarca.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_CadastrarMarca.OnPressedState.BorderRadius = 1;
            this.btn_CadastrarMarca.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_CadastrarMarca.OnPressedState.BorderThickness = 1;
            this.btn_CadastrarMarca.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_CadastrarMarca.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_CadastrarMarca.OnPressedState.IconLeftImage = null;
            this.btn_CadastrarMarca.OnPressedState.IconRightImage = null;
            this.btn_CadastrarMarca.Size = new System.Drawing.Size(157, 36);
            this.btn_CadastrarMarca.TabIndex = 21;
            this.btn_CadastrarMarca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_CadastrarMarca.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_CadastrarMarca.TextMarginLeft = 0;
            this.btn_CadastrarMarca.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_CadastrarMarca.UseDefaultRadiusAndThickness = true;
            this.btn_CadastrarMarca.Click += new System.EventHandler(this.btn_CadastrarMarca_Click);
            // 
            // NumUp_ValorVenda
            // 
            this.NumUp_ValorVenda.BackColor = System.Drawing.Color.FloralWhite;
            this.NumUp_ValorVenda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumUp_ValorVenda.DecimalPlaces = 2;
            this.NumUp_ValorVenda.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumUp_ValorVenda.ForeColor = System.Drawing.Color.DarkOrchid;
            this.NumUp_ValorVenda.Location = new System.Drawing.Point(355, 189);
            this.NumUp_ValorVenda.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumUp_ValorVenda.Name = "NumUp_ValorVenda";
            this.NumUp_ValorVenda.Size = new System.Drawing.Size(189, 29);
            this.NumUp_ValorVenda.TabIndex = 20;
            this.NumUp_ValorVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumUp_ValorVenda.ValueChanged += new System.EventHandler(this.NumUp_ValorVenda_ValueChanged);
            // 
            // bunifuLabel6
            // 
            this.bunifuLabel6.AllowParentOverrides = false;
            this.bunifuLabel6.AutoEllipsis = false;
            this.bunifuLabel6.CursorType = null;
            this.bunifuLabel6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bunifuLabel6.Location = new System.Drawing.Point(400, 162);
            this.bunifuLabel6.Name = "bunifuLabel6";
            this.bunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel6.Size = new System.Drawing.Size(131, 21);
            this.bunifuLabel6.TabIndex = 19;
            this.bunifuLabel6.Text = "VALOR DE VENDA:";
            this.bunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // NumUp_PerLucro
            // 
            this.NumUp_PerLucro.BackColor = System.Drawing.Color.FloralWhite;
            this.NumUp_PerLucro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumUp_PerLucro.DecimalPlaces = 2;
            this.NumUp_PerLucro.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumUp_PerLucro.ForeColor = System.Drawing.Color.DarkOrchid;
            this.NumUp_PerLucro.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.NumUp_PerLucro.Location = new System.Drawing.Point(227, 189);
            this.NumUp_PerLucro.Name = "NumUp_PerLucro";
            this.NumUp_PerLucro.Size = new System.Drawing.Size(122, 29);
            this.NumUp_PerLucro.TabIndex = 18;
            this.NumUp_PerLucro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumUp_PerLucro.ValueChanged += new System.EventHandler(this.NumUp_PerLucro_ValueChanged);
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AllowParentOverrides = false;
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.CursorType = null;
            this.bunifuLabel5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bunifuLabel5.Location = new System.Drawing.Point(227, 162);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(112, 21);
            this.bunifuLabel5.TabIndex = 17;
            this.bunifuLabel5.Text = "PERC. LUCRO %";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // NumUp_ValorCusto
            // 
            this.NumUp_ValorCusto.BackColor = System.Drawing.Color.FloralWhite;
            this.NumUp_ValorCusto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumUp_ValorCusto.DecimalPlaces = 2;
            this.NumUp_ValorCusto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumUp_ValorCusto.ForeColor = System.Drawing.Color.DarkOrchid;
            this.NumUp_ValorCusto.Location = new System.Drawing.Point(15, 189);
            this.NumUp_ValorCusto.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumUp_ValorCusto.Name = "NumUp_ValorCusto";
            this.NumUp_ValorCusto.Size = new System.Drawing.Size(202, 29);
            this.NumUp_ValorCusto.TabIndex = 16;
            this.NumUp_ValorCusto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumUp_ValorCusto.ValueChanged += new System.EventHandler(this.NumUp_ValorCusto_ValueChanged);
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bunifuLabel4.Location = new System.Drawing.Point(42, 162);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(130, 21);
            this.bunifuLabel4.TabIndex = 8;
            this.bunifuLabel4.Text = "VALOR DE CUSTO:";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bunifuLabel3.Location = new System.Drawing.Point(400, 71);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(124, 21);
            this.bunifuLabel3.TabIndex = 6;
            this.bunifuLabel3.Text = "ESTOQUE INICIAL";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txt_NomeMarcaCimento
            // 
            this.txt_NomeMarcaCimento.AcceptsReturn = false;
            this.txt_NomeMarcaCimento.AcceptsTab = false;
            this.txt_NomeMarcaCimento.AnimationSpeed = 200;
            this.txt_NomeMarcaCimento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_NomeMarcaCimento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_NomeMarcaCimento.BackColor = System.Drawing.Color.White;
            this.txt_NomeMarcaCimento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_NomeMarcaCimento.BackgroundImage")));
            this.txt_NomeMarcaCimento.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_NomeMarcaCimento.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_NomeMarcaCimento.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_NomeMarcaCimento.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_NomeMarcaCimento.BorderRadius = 1;
            this.txt_NomeMarcaCimento.BorderThickness = 1;
            this.txt_NomeMarcaCimento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_NomeMarcaCimento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_NomeMarcaCimento.DefaultFont = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.txt_NomeMarcaCimento.DefaultText = "";
            this.txt_NomeMarcaCimento.FillColor = System.Drawing.Color.White;
            this.txt_NomeMarcaCimento.HideSelection = true;
            this.txt_NomeMarcaCimento.IconLeft = null;
            this.txt_NomeMarcaCimento.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_NomeMarcaCimento.IconPadding = 10;
            this.txt_NomeMarcaCimento.IconRight = null;
            this.txt_NomeMarcaCimento.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_NomeMarcaCimento.Lines = new string[0];
            this.txt_NomeMarcaCimento.Location = new System.Drawing.Point(17, 98);
            this.txt_NomeMarcaCimento.MaxLength = 32767;
            this.txt_NomeMarcaCimento.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_NomeMarcaCimento.Modified = false;
            this.txt_NomeMarcaCimento.Multiline = false;
            this.txt_NomeMarcaCimento.Name = "txt_NomeMarcaCimento";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_NomeMarcaCimento.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_NomeMarcaCimento.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_NomeMarcaCimento.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_NomeMarcaCimento.OnIdleState = stateProperties4;
            this.txt_NomeMarcaCimento.Padding = new System.Windows.Forms.Padding(3);
            this.txt_NomeMarcaCimento.PasswordChar = '\0';
            this.txt_NomeMarcaCimento.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_NomeMarcaCimento.PlaceholderText = "ENTER TEXT";
            this.txt_NomeMarcaCimento.ReadOnly = false;
            this.txt_NomeMarcaCimento.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_NomeMarcaCimento.SelectedText = "";
            this.txt_NomeMarcaCimento.SelectionLength = 0;
            this.txt_NomeMarcaCimento.SelectionStart = 0;
            this.txt_NomeMarcaCimento.ShortcutsEnabled = true;
            this.txt_NomeMarcaCimento.Size = new System.Drawing.Size(360, 40);
            this.txt_NomeMarcaCimento.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.txt_NomeMarcaCimento.TabIndex = 5;
            this.txt_NomeMarcaCimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_NomeMarcaCimento.TextMarginBottom = 0;
            this.txt_NomeMarcaCimento.TextMarginLeft = 3;
            this.txt_NomeMarcaCimento.TextMarginTop = 0;
            this.txt_NomeMarcaCimento.TextPlaceholder = "ENTER TEXT";
            this.txt_NomeMarcaCimento.UseSystemPasswordChar = false;
            this.txt_NomeMarcaCimento.WordWrap = true;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bunifuLabel2.Location = new System.Drawing.Point(19, 71);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(153, 21);
            this.bunifuLabel2.TabIndex = 4;
            this.bunifuLabel2.Text = "MARCA DO CIMENTO";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(17, 51);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(528, 14);
            this.bunifuSeparator1.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::SICP.Properties.Resources.FECHA;
            this.button3.Location = new System.Drawing.Point(476, -101);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 50);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // LB_Operacao
            // 
            this.LB_Operacao.AllowParentOverrides = false;
            this.LB_Operacao.AutoEllipsis = false;
            this.LB_Operacao.CursorType = null;
            this.LB_Operacao.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.LB_Operacao.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LB_Operacao.Location = new System.Drawing.Point(17, 15);
            this.LB_Operacao.Name = "LB_Operacao";
            this.LB_Operacao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LB_Operacao.Size = new System.Drawing.Size(155, 30);
            this.LB_Operacao.TabIndex = 1;
            this.LB_Operacao.Text = "Tela de Cadastro";
            this.LB_Operacao.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.LB_Operacao.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // NumUp_EstoqueInicial
            // 
            this.NumUp_EstoqueInicial.BackColor = System.Drawing.Color.FloralWhite;
            this.NumUp_EstoqueInicial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumUp_EstoqueInicial.DecimalPlaces = 2;
            this.NumUp_EstoqueInicial.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumUp_EstoqueInicial.ForeColor = System.Drawing.Color.DarkOrchid;
            this.NumUp_EstoqueInicial.Location = new System.Drawing.Point(383, 109);
            this.NumUp_EstoqueInicial.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumUp_EstoqueInicial.Name = "NumUp_EstoqueInicial";
            this.NumUp_EstoqueInicial.Size = new System.Drawing.Size(163, 29);
            this.NumUp_EstoqueInicial.TabIndex = 28;
            this.NumUp_EstoqueInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmCadCimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 342);
            this.Controls.Add(this.bunifuCards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCadCimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadCimento";
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUp_ValorVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUp_PerLucro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUp_ValorCusto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUp_EstoqueInicial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private System.Windows.Forms.Button button3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel6;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        public Bunifu.UI.WinForms.BunifuTextBox txt_NomeMarcaCimento;
        public System.Windows.Forms.NumericUpDown NumUp_ValorCusto;
        public System.Windows.Forms.NumericUpDown NumUp_PerLucro;
        public System.Windows.Forms.NumericUpDown NumUp_ValorVenda;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_CadastrarMarca;
        public System.Windows.Forms.Button btn_FecharJanela;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator2;
        public Bunifu.UI.WinForms.BunifuLabel lb_codigoMat;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_EditarDados;
        public Bunifu.UI.WinForms.BunifuLabel LB_Operacao;
        public Bunifu.UI.WinForms.BunifuLabel Lb_ValLucro;
        public System.Windows.Forms.NumericUpDown NumUp_EstoqueInicial;
    }
}