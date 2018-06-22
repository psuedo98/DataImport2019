namespace WipViewer
{
    partial class AJSchedule
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
            this.components = new System.ComponentModel.Container();
            this.btnSubmit = new Syncfusion.Windows.Forms.ButtonAdv();
            this.cmb1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb2 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.cmb3 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.cmb4 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.cmb5 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.cmb6 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.cmb7 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.cmb8 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.cmb9 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.cmb18 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.cmb17 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.cmb16 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.cmb15 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.cmb14 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.cmb13 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.cmb12 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.cmb11 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.cmb10 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            ((System.ComponentModel.ISupportInitialize)(this.cmb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb10)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.btnSubmit.BeforeTouchSize = new System.Drawing.Size(136, 23);
            this.btnSubmit.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.None;
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.IsBackStageButton = false;
            this.btnSubmit.Location = new System.Drawing.Point(605, 457);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(136, 23);
            this.btnSubmit.TabIndex = 17;
            this.btnSubmit.Text = "Submit Schedule";
            this.btnSubmit.UseVisualStyle = true;
            this.btnSubmit.Click += new System.EventHandler(this.buttonAdv1_Click);
            // 
            // cmb1
            // 
            this.cmb1.BackColor = System.Drawing.Color.White;
            this.cmb1.BeforeTouchSize = new System.Drawing.Size(176, 21);
            this.cmb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb1.Items.AddRange(new object[] {
            "Held For Data",
            "Start Fab",
            "Finish Fab",
            "Start Machine (3 Axis)",
            "Finish Machine (3 Axis)",
            "Start Machine (5 Axis)",
            "Finish Machine (5 Axis)",
            "Start Assembly",
            "Finish Assmbly",
            "Start Heat Treat",
            "Finish Heat Treat",
            "Material Order Start",
            "Material Order Finish",
            "Start Bench",
            "Finish Bench",
            "Start Paint",
            "Finish Paint",
            "Finalize Start",
            "Finalize Finish",
            "Tracker Start",
            "Tracker Finish",
            "Start QA",
            "Finish QA",
            "Sell to Source",
            "Commercial Items Order",
            "Commercial Items Receive",
            "Design Start",
            "Design Finish",
            "Release to Manufacturing"});
            this.cmb1.Location = new System.Drawing.Point(44, 54);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(176, 21);
            this.cmb1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cmb1.TabIndex = 18;
            this.cmb1.SelectedValueChanged += new System.EventHandler(this.cmb1_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Please Select Your Scheduling Items";
            // 
            // cmb2
            // 
            this.cmb2.BackColor = System.Drawing.Color.White;
            this.cmb2.BeforeTouchSize = new System.Drawing.Size(176, 21);
            this.cmb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb2.Items.AddRange(new object[] {
            "Held For Data",
            "Start Fab",
            "Finish Fab",
            "Start Machine (3 Axis)",
            "Finish Machine (3 Axis)",
            "Start Machine (5 Axis)",
            "Finish Machine (5 Axis)",
            "Start Assembly",
            "Finish Assmbly",
            "Start Heat Treat",
            "Finish Heat Treat",
            "Material Order Start",
            "Material Order Finish",
            "Start Bench",
            "Finish Bench",
            "Start Paint",
            "Finish Paint",
            "Finalize Start",
            "Finalize Finish",
            "Tracker Start",
            "Tracker Finish",
            "Start QA",
            "Finish QA",
            "Sell to Source",
            "Commercial Items Order",
            "Commercial Items Receive",
            "Design Start",
            "Design Finish",
            "Release to Manufacturing"});
            this.cmb2.Location = new System.Drawing.Point(44, 91);
            this.cmb2.Name = "cmb2";
            this.cmb2.Size = new System.Drawing.Size(176, 21);
            this.cmb2.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cmb2.TabIndex = 20;
            this.cmb2.SelectedValueChanged += new System.EventHandler(this.cmb2_SelectedValueChanged);
            // 
            // cmb3
            // 
            this.cmb3.BackColor = System.Drawing.Color.White;
            this.cmb3.BeforeTouchSize = new System.Drawing.Size(176, 21);
            this.cmb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb3.Items.AddRange(new object[] {
            "Held For Data",
            "Start Fab",
            "Finish Fab",
            "Start Machine (3 Axis)",
            "Finish Machine (3 Axis)",
            "Start Machine (5 Axis)",
            "Finish Machine (5 Axis)",
            "Start Assembly",
            "Finish Assmbly",
            "Start Heat Treat",
            "Finish Heat Treat",
            "Material Order Start",
            "Material Order Finish",
            "Start Bench",
            "Finish Bench",
            "Start Paint",
            "Finish Paint",
            "Finalize Start",
            "Finalize Finish",
            "Tracker Start",
            "Tracker Finish",
            "Start QA",
            "Finish QA",
            "Sell to Source",
            "Commercial Items Order",
            "Commercial Items Receive",
            "Design Start",
            "Design Finish",
            "Release to Manufacturing"});
            this.cmb3.Location = new System.Drawing.Point(44, 128);
            this.cmb3.Name = "cmb3";
            this.cmb3.Size = new System.Drawing.Size(176, 21);
            this.cmb3.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cmb3.TabIndex = 21;
            this.cmb3.SelectedValueChanged += new System.EventHandler(this.comboBoxAdv1_SelectedValueChanged);
            this.cmb3.Click += new System.EventHandler(this.cmb3_Click);
            // 
            // cmb4
            // 
            this.cmb4.BackColor = System.Drawing.Color.White;
            this.cmb4.BeforeTouchSize = new System.Drawing.Size(176, 21);
            this.cmb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb4.Items.AddRange(new object[] {
            "Held For Data",
            "Start Fab",
            "Finish Fab",
            "Start Machine (3 Axis)",
            "Finish Machine (3 Axis)",
            "Start Machine (5 Axis)",
            "Finish Machine (5 Axis)",
            "Start Assembly",
            "Finish Assmbly",
            "Start Heat Treat",
            "Finish Heat Treat",
            "Material Order Start",
            "Material Order Finish",
            "Start Bench",
            "Finish Bench",
            "Start Paint",
            "Finish Paint",
            "Finalize Start",
            "Finalize Finish",
            "Tracker Start",
            "Tracker Finish",
            "Start QA",
            "Finish QA",
            "Sell to Source",
            "Commercial Items Order",
            "Commercial Items Receive",
            "Design Start",
            "Design Finish",
            "Release to Manufacturing"});
            this.cmb4.Location = new System.Drawing.Point(44, 165);
            this.cmb4.Name = "cmb4";
            this.cmb4.Size = new System.Drawing.Size(176, 21);
            this.cmb4.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cmb4.TabIndex = 22;
            this.cmb4.SelectedValueChanged += new System.EventHandler(this.cmb4_SelectedValueChanged);
            // 
            // cmb5
            // 
            this.cmb5.BackColor = System.Drawing.Color.White;
            this.cmb5.BeforeTouchSize = new System.Drawing.Size(176, 21);
            this.cmb5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb5.Items.AddRange(new object[] {
            "Held For Data",
            "Start Fab",
            "Finish Fab",
            "Start Machine (3 Axis)",
            "Finish Machine (3 Axis)",
            "Start Machine (5 Axis)",
            "Finish Machine (5 Axis)",
            "Start Assembly",
            "Finish Assmbly",
            "Start Heat Treat",
            "Finish Heat Treat",
            "Material Order Start",
            "Material Order Finish",
            "Start Bench",
            "Finish Bench",
            "Start Paint",
            "Finish Paint",
            "Finalize Start",
            "Finalize Finish",
            "Tracker Start",
            "Tracker Finish",
            "Start QA",
            "Finish QA",
            "Sell to Source",
            "Commercial Items Order",
            "Commercial Items Receive",
            "Design Start",
            "Design Finish",
            "Release to Manufacturing"});
            this.cmb5.Location = new System.Drawing.Point(44, 202);
            this.cmb5.Name = "cmb5";
            this.cmb5.Size = new System.Drawing.Size(176, 21);
            this.cmb5.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cmb5.TabIndex = 23;
            this.cmb5.SelectedValueChanged += new System.EventHandler(this.cmb5_SelectedValueChanged);
            // 
            // cmb6
            // 
            this.cmb6.BackColor = System.Drawing.Color.White;
            this.cmb6.BeforeTouchSize = new System.Drawing.Size(176, 21);
            this.cmb6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb6.Items.AddRange(new object[] {
            "Held For Data",
            "Start Fab",
            "Finish Fab",
            "Start Machine (3 Axis)",
            "Finish Machine (3 Axis)",
            "Start Machine (5 Axis)",
            "Finish Machine (5 Axis)",
            "Start Assembly",
            "Finish Assmbly",
            "Start Heat Treat",
            "Finish Heat Treat",
            "Material Order Start",
            "Material Order Finish",
            "Start Bench",
            "Finish Bench",
            "Start Paint",
            "Finish Paint",
            "Finalize Start",
            "Finalize Finish",
            "Tracker Start",
            "Tracker Finish",
            "Start QA",
            "Finish QA",
            "Sell to Source",
            "Commercial Items Order",
            "Commercial Items Receive",
            "Design Start",
            "Design Finish",
            "Release to Manufacturing"});
            this.cmb6.Location = new System.Drawing.Point(44, 239);
            this.cmb6.Name = "cmb6";
            this.cmb6.Size = new System.Drawing.Size(176, 21);
            this.cmb6.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cmb6.TabIndex = 24;
            this.cmb6.SelectedValueChanged += new System.EventHandler(this.cmb6_SelectedValueChanged);
            // 
            // cmb7
            // 
            this.cmb7.BackColor = System.Drawing.Color.White;
            this.cmb7.BeforeTouchSize = new System.Drawing.Size(176, 21);
            this.cmb7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb7.Items.AddRange(new object[] {
            "Held For Data",
            "Start Fab",
            "Finish Fab",
            "Start Machine (3 Axis)",
            "Finish Machine (3 Axis)",
            "Start Machine (5 Axis)",
            "Finish Machine (5 Axis)",
            "Start Assembly",
            "Finish Assmbly",
            "Start Heat Treat",
            "Finish Heat Treat",
            "Material Order Start",
            "Material Order Finish",
            "Start Bench",
            "Finish Bench",
            "Start Paint",
            "Finish Paint",
            "Finalize Start",
            "Finalize Finish",
            "Tracker Start",
            "Tracker Finish",
            "Start QA",
            "Finish QA",
            "Sell to Source",
            "Commercial Items Order",
            "Commercial Items Receive",
            "Design Start",
            "Design Finish",
            "Release to Manufacturing"});
            this.cmb7.Location = new System.Drawing.Point(44, 276);
            this.cmb7.Name = "cmb7";
            this.cmb7.Size = new System.Drawing.Size(176, 21);
            this.cmb7.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cmb7.TabIndex = 25;
            this.cmb7.SelectedValueChanged += new System.EventHandler(this.cmb7_SelectedValueChanged);
            // 
            // cmb8
            // 
            this.cmb8.BackColor = System.Drawing.Color.White;
            this.cmb8.BeforeTouchSize = new System.Drawing.Size(176, 21);
            this.cmb8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb8.Items.AddRange(new object[] {
            "Held For Data",
            "Start Fab",
            "Finish Fab",
            "Start Machine (3 Axis)",
            "Finish Machine (3 Axis)",
            "Start Machine (5 Axis)",
            "Finish Machine (5 Axis)",
            "Start Assembly",
            "Finish Assmbly",
            "Start Heat Treat",
            "Finish Heat Treat",
            "Material Order Start",
            "Material Order Finish",
            "Start Bench",
            "Finish Bench",
            "Start Paint",
            "Finish Paint",
            "Finalize Start",
            "Finalize Finish",
            "Tracker Start",
            "Tracker Finish",
            "Start QA",
            "Finish QA",
            "Sell to Source",
            "Commercial Items Order",
            "Commercial Items Receive",
            "Design Start",
            "Design Finish",
            "Release to Manufacturing"});
            this.cmb8.Location = new System.Drawing.Point(44, 313);
            this.cmb8.Name = "cmb8";
            this.cmb8.Size = new System.Drawing.Size(176, 21);
            this.cmb8.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cmb8.TabIndex = 26;
            this.cmb8.SelectedValueChanged += new System.EventHandler(this.cmb8_SelectedValueChanged);
            // 
            // cmb9
            // 
            this.cmb9.BackColor = System.Drawing.Color.White;
            this.cmb9.BeforeTouchSize = new System.Drawing.Size(176, 21);
            this.cmb9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb9.Items.AddRange(new object[] {
            "Held For Data",
            "Start Fab",
            "Finish Fab",
            "Start Machine (3 Axis)",
            "Finish Machine (3 Axis)",
            "Start Machine (5 Axis)",
            "Finish Machine (5 Axis)",
            "Start Assembly",
            "Finish Assmbly",
            "Start Heat Treat",
            "Finish Heat Treat",
            "Material Order Start",
            "Material Order Finish",
            "Start Bench",
            "Finish Bench",
            "Start Paint",
            "Finish Paint",
            "Finalize Start",
            "Finalize Finish",
            "Tracker Start",
            "Tracker Finish",
            "Start QA",
            "Finish QA",
            "Sell to Source",
            "Commercial Items Order",
            "Commercial Items Receive",
            "Design Start",
            "Design Finish",
            "Release to Manufacturing"});
            this.cmb9.Location = new System.Drawing.Point(44, 350);
            this.cmb9.Name = "cmb9";
            this.cmb9.Size = new System.Drawing.Size(176, 21);
            this.cmb9.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cmb9.TabIndex = 27;
            this.cmb9.SelectedValueChanged += new System.EventHandler(this.cmb9_SelectedValueChanged);
            // 
            // cmb18
            // 
            this.cmb18.BackColor = System.Drawing.Color.White;
            this.cmb18.BeforeTouchSize = new System.Drawing.Size(176, 21);
            this.cmb18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb18.Items.AddRange(new object[] {
            "Held For Data",
            "Start Fab",
            "Finish Fab",
            "Start Machine (3 Axis)",
            "Finish Machine (3 Axis)",
            "Start Machine (5 Axis)",
            "Finish Machine (5 Axis)",
            "Start Assembly",
            "Finish Assmbly",
            "Start Heat Treat",
            "Finish Heat Treat",
            "Material Order Start",
            "Material Order Finish",
            "Start Bench",
            "Finish Bench",
            "Start Paint",
            "Finish Paint",
            "Finalize Start",
            "Finalize Finish",
            "Tracker Start",
            "Tracker Finish",
            "Start QA",
            "Finish QA",
            "Sell to Source",
            "Commercial Items Order",
            "Commercial Items Receive",
            "Design Start",
            "Design Finish",
            "Release to Manufacturing"});
            this.cmb18.Location = new System.Drawing.Point(446, 350);
            this.cmb18.Name = "cmb18";
            this.cmb18.Size = new System.Drawing.Size(176, 21);
            this.cmb18.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cmb18.TabIndex = 36;
            this.cmb18.SelectedValueChanged += new System.EventHandler(this.cmb18_SelectedValueChanged);
            // 
            // cmb17
            // 
            this.cmb17.BackColor = System.Drawing.Color.White;
            this.cmb17.BeforeTouchSize = new System.Drawing.Size(176, 21);
            this.cmb17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb17.Items.AddRange(new object[] {
            "Held For Data",
            "Start Fab",
            "Finish Fab",
            "Start Machine (3 Axis)",
            "Finish Machine (3 Axis)",
            "Start Machine (5 Axis)",
            "Finish Machine (5 Axis)",
            "Start Assembly",
            "Finish Assmbly",
            "Start Heat Treat",
            "Finish Heat Treat",
            "Material Order Start",
            "Material Order Finish",
            "Start Bench",
            "Finish Bench",
            "Start Paint",
            "Finish Paint",
            "Finalize Start",
            "Finalize Finish",
            "Tracker Start",
            "Tracker Finish",
            "Start QA",
            "Finish QA",
            "Sell to Source",
            "Commercial Items Order",
            "Commercial Items Receive",
            "Design Start",
            "Design Finish",
            "Release to Manufacturing"});
            this.cmb17.Location = new System.Drawing.Point(446, 313);
            this.cmb17.Name = "cmb17";
            this.cmb17.Size = new System.Drawing.Size(176, 21);
            this.cmb17.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cmb17.TabIndex = 35;
            this.cmb17.SelectedValueChanged += new System.EventHandler(this.cmb17_SelectedValueChanged);
            // 
            // cmb16
            // 
            this.cmb16.BackColor = System.Drawing.Color.White;
            this.cmb16.BeforeTouchSize = new System.Drawing.Size(176, 21);
            this.cmb16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb16.Items.AddRange(new object[] {
            "Held For Data",
            "Start Fab",
            "Finish Fab",
            "Start Machine (3 Axis)",
            "Finish Machine (3 Axis)",
            "Start Machine (5 Axis)",
            "Finish Machine (5 Axis)",
            "Start Assembly",
            "Finish Assmbly",
            "Start Heat Treat",
            "Finish Heat Treat",
            "Material Order Start",
            "Material Order Finish",
            "Start Bench",
            "Finish Bench",
            "Start Paint",
            "Finish Paint",
            "Finalize Start",
            "Finalize Finish",
            "Tracker Start",
            "Tracker Finish",
            "Start QA",
            "Finish QA",
            "Sell to Source",
            "Commercial Items Order",
            "Commercial Items Receive",
            "Design Start",
            "Design Finish",
            "Release to Manufacturing"});
            this.cmb16.Location = new System.Drawing.Point(446, 276);
            this.cmb16.Name = "cmb16";
            this.cmb16.Size = new System.Drawing.Size(176, 21);
            this.cmb16.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cmb16.TabIndex = 34;
            this.cmb16.SelectedValueChanged += new System.EventHandler(this.cmb16_SelectedValueChanged);
            // 
            // cmb15
            // 
            this.cmb15.BackColor = System.Drawing.Color.White;
            this.cmb15.BeforeTouchSize = new System.Drawing.Size(176, 21);
            this.cmb15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb15.Items.AddRange(new object[] {
            "Held For Data",
            "Start Fab",
            "Finish Fab",
            "Start Machine (3 Axis)",
            "Finish Machine (3 Axis)",
            "Start Machine (5 Axis)",
            "Finish Machine (5 Axis)",
            "Start Assembly",
            "Finish Assmbly",
            "Start Heat Treat",
            "Finish Heat Treat",
            "Material Order Start",
            "Material Order Finish",
            "Start Bench",
            "Finish Bench",
            "Start Paint",
            "Finish Paint",
            "Finalize Start",
            "Finalize Finish",
            "Tracker Start",
            "Tracker Finish",
            "Start QA",
            "Finish QA",
            "Sell to Source",
            "Commercial Items Order",
            "Commercial Items Receive",
            "Design Start",
            "Design Finish",
            "Release to Manufacturing"});
            this.cmb15.Location = new System.Drawing.Point(446, 239);
            this.cmb15.Name = "cmb15";
            this.cmb15.Size = new System.Drawing.Size(176, 21);
            this.cmb15.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cmb15.TabIndex = 33;
            this.cmb15.SelectedValueChanged += new System.EventHandler(this.cmb15_SelectedValueChanged);
            // 
            // cmb14
            // 
            this.cmb14.BackColor = System.Drawing.Color.White;
            this.cmb14.BeforeTouchSize = new System.Drawing.Size(176, 21);
            this.cmb14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb14.Items.AddRange(new object[] {
            "Held For Data",
            "Start Fab",
            "Finish Fab",
            "Start Machine (3 Axis)",
            "Finish Machine (3 Axis)",
            "Start Machine (5 Axis)",
            "Finish Machine (5 Axis)",
            "Start Assembly",
            "Finish Assmbly",
            "Start Heat Treat",
            "Finish Heat Treat",
            "Material Order Start",
            "Material Order Finish",
            "Start Bench",
            "Finish Bench",
            "Start Paint",
            "Finish Paint",
            "Finalize Start",
            "Finalize Finish",
            "Tracker Start",
            "Tracker Finish",
            "Start QA",
            "Finish QA",
            "Sell to Source",
            "Commercial Items Order",
            "Commercial Items Receive",
            "Design Start",
            "Design Finish",
            "Release to Manufacturing"});
            this.cmb14.Location = new System.Drawing.Point(446, 202);
            this.cmb14.Name = "cmb14";
            this.cmb14.Size = new System.Drawing.Size(176, 21);
            this.cmb14.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cmb14.TabIndex = 32;
            this.cmb14.SelectedValueChanged += new System.EventHandler(this.cmb14_SelectedValueChanged);
            // 
            // cmb13
            // 
            this.cmb13.BackColor = System.Drawing.Color.White;
            this.cmb13.BeforeTouchSize = new System.Drawing.Size(176, 21);
            this.cmb13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb13.Items.AddRange(new object[] {
            "Held For Data",
            "Start Fab",
            "Finish Fab",
            "Start Machine (3 Axis)",
            "Finish Machine (3 Axis)",
            "Start Machine (5 Axis)",
            "Finish Machine (5 Axis)",
            "Start Assembly",
            "Finish Assmbly",
            "Start Heat Treat",
            "Finish Heat Treat",
            "Material Order Start",
            "Material Order Finish",
            "Start Bench",
            "Finish Bench",
            "Start Paint",
            "Finish Paint",
            "Finalize Start",
            "Finalize Finish",
            "Tracker Start",
            "Tracker Finish",
            "Start QA",
            "Finish QA",
            "Sell to Source",
            "Commercial Items Order",
            "Commercial Items Receive",
            "Design Start",
            "Design Finish",
            "Release to Manufacturing"});
            this.cmb13.Location = new System.Drawing.Point(446, 165);
            this.cmb13.Name = "cmb13";
            this.cmb13.Size = new System.Drawing.Size(176, 21);
            this.cmb13.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cmb13.TabIndex = 31;
            this.cmb13.SelectedValueChanged += new System.EventHandler(this.cmb13_SelectedValueChanged);
            // 
            // cmb12
            // 
            this.cmb12.BackColor = System.Drawing.Color.White;
            this.cmb12.BeforeTouchSize = new System.Drawing.Size(176, 21);
            this.cmb12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb12.Items.AddRange(new object[] {
            "Held For Data",
            "Start Fab",
            "Finish Fab",
            "Start Machine (3 Axis)",
            "Finish Machine (3 Axis)",
            "Start Machine (5 Axis)",
            "Finish Machine (5 Axis)",
            "Start Assembly",
            "Finish Assmbly",
            "Start Heat Treat",
            "Finish Heat Treat",
            "Material Order Start",
            "Material Order Finish",
            "Start Bench",
            "Finish Bench",
            "Start Paint",
            "Finish Paint",
            "Finalize Start",
            "Finalize Finish",
            "Tracker Start",
            "Tracker Finish",
            "Start QA",
            "Finish QA",
            "Sell to Source",
            "Commercial Items Order",
            "Commercial Items Receive",
            "Design Start",
            "Design Finish",
            "Release to Manufacturing"});
            this.cmb12.Location = new System.Drawing.Point(446, 128);
            this.cmb12.Name = "cmb12";
            this.cmb12.Size = new System.Drawing.Size(176, 21);
            this.cmb12.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cmb12.TabIndex = 30;
            this.cmb12.SelectedValueChanged += new System.EventHandler(this.cmb12_SelectedValueChanged);
            // 
            // cmb11
            // 
            this.cmb11.BackColor = System.Drawing.Color.White;
            this.cmb11.BeforeTouchSize = new System.Drawing.Size(176, 21);
            this.cmb11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb11.Items.AddRange(new object[] {
            "Held For Data",
            "Start Fab",
            "Finish Fab",
            "Start Machine (3 Axis)",
            "Finish Machine (3 Axis)",
            "Start Machine (5 Axis)",
            "Finish Machine (5 Axis)",
            "Start Assembly",
            "Finish Assmbly",
            "Start Heat Treat",
            "Finish Heat Treat",
            "Material Order Start",
            "Material Order Finish",
            "Start Bench",
            "Finish Bench",
            "Start Paint",
            "Finish Paint",
            "Finalize Start",
            "Finalize Finish",
            "Tracker Start",
            "Tracker Finish",
            "Start QA",
            "Finish QA",
            "Sell to Source",
            "Commercial Items Order",
            "Commercial Items Receive",
            "Design Start",
            "Design Finish",
            "Release to Manufacturing"});
            this.cmb11.Location = new System.Drawing.Point(446, 91);
            this.cmb11.Name = "cmb11";
            this.cmb11.Size = new System.Drawing.Size(176, 21);
            this.cmb11.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cmb11.TabIndex = 29;
            this.cmb11.SelectedValueChanged += new System.EventHandler(this.cmb11_SelectedValueChanged);
            // 
            // cmb10
            // 
            this.cmb10.BackColor = System.Drawing.Color.White;
            this.cmb10.BeforeTouchSize = new System.Drawing.Size(176, 21);
            this.cmb10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb10.Items.AddRange(new object[] {
            "Held For Data",
            "Start Fab",
            "Finish Fab",
            "Start Machine (3 Axis)",
            "Finish Machine (3 Axis)",
            "Start Machine (5 Axis)",
            "Finish Machine (5 Axis)",
            "Start Assembly",
            "Finish Assmbly",
            "Start Heat Treat",
            "Finish Heat Treat",
            "Material Order Start",
            "Material Order Finish",
            "Start Bench",
            "Finish Bench",
            "Start Paint",
            "Finish Paint",
            "Finalize Start",
            "Finalize Finish",
            "Tracker Start",
            "Tracker Finish",
            "Start QA",
            "Finish QA",
            "Sell to Source",
            "Commercial Items Order",
            "Commercial Items Receive",
            "Design Start",
            "Design Finish",
            "Release to Manufacturing"});
            this.cmb10.Location = new System.Drawing.Point(446, 54);
            this.cmb10.Name = "cmb10";
            this.cmb10.Size = new System.Drawing.Size(176, 21);
            this.cmb10.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.cmb10.TabIndex = 28;
            this.cmb10.SelectedValueChanged += new System.EventHandler(this.cmb10_SelectedValueChanged);
            // 
            // AJSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(866, 516);
            this.Controls.Add(this.cmb18);
            this.Controls.Add(this.cmb17);
            this.Controls.Add(this.cmb16);
            this.Controls.Add(this.cmb15);
            this.Controls.Add(this.cmb14);
            this.Controls.Add(this.cmb13);
            this.Controls.Add(this.cmb12);
            this.Controls.Add(this.cmb11);
            this.Controls.Add(this.cmb10);
            this.Controls.Add(this.cmb9);
            this.Controls.Add(this.cmb8);
            this.Controls.Add(this.cmb7);
            this.Controls.Add(this.cmb6);
            this.Controls.Add(this.cmb5);
            this.Controls.Add(this.cmb4);
            this.Controls.Add(this.cmb3);
            this.Controls.Add(this.cmb2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb1);
            this.Controls.Add(this.btnSubmit);
            this.Name = "AJSchedule";
            this.Text = "AJSchedule";
            ((System.ComponentModel.ISupportInitialize)(this.cmb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Syncfusion.Windows.Forms.ButtonAdv btnSubmit;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmb1;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmb2;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmb3;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmb4;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmb5;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmb6;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmb7;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmb8;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmb9;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmb18;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmb17;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmb16;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmb15;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmb14;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmb13;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmb12;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmb11;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmb10;
    }
}