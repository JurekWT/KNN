namespace KNN;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        buttonLoadSamples = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        groupBoxLoadSamples = new System.Windows.Forms.GroupBox();
        labelSamplesLoaded = new System.Windows.Forms.Label();
        openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
        buttonStart = new System.Windows.Forms.Button();
        groupBoxMetrics = new System.Windows.Forms.GroupBox();
        radioButtonLog = new System.Windows.Forms.RadioButton();
        radioButtonCzebyszew = new System.Windows.Forms.RadioButton();
        radioButtonEuclid = new System.Windows.Forms.RadioButton();
        radioButtonManhattan = new System.Windows.Forms.RadioButton();
        numericUpDown1 = new System.Windows.Forms.NumericUpDown();
        groupBox1 = new System.Windows.Forms.GroupBox();
        radioKTotal = new System.Windows.Forms.RadioButton();
        radioKEach = new System.Windows.Forms.RadioButton();
        label2 = new System.Windows.Forms.Label();
        textBoxOutput = new System.Windows.Forms.TextBox();
        groupBoxLoadSamples.SuspendLayout();
        groupBoxMetrics.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // buttonLoadSamples
        // 
        buttonLoadSamples.Dock = System.Windows.Forms.DockStyle.Top;
        buttonLoadSamples.Location = new System.Drawing.Point(3, 23);
        buttonLoadSamples.Margin = new System.Windows.Forms.Padding(10);
        buttonLoadSamples.Name = "buttonLoadSamples";
        buttonLoadSamples.Size = new System.Drawing.Size(230, 50);
        buttonLoadSamples.TabIndex = 0;
        buttonLoadSamples.Text = "Wczytaj";
        buttonLoadSamples.UseVisualStyleBackColor = true;
        buttonLoadSamples.Click += buttonLoadSamples_Click;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 11F);
        label1.Location = new System.Drawing.Point(-11, 0);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(597, 54);
        label1.TabIndex = 1;
        label1.Text = "Klasyfikator k-nn, walidacja 1 vs reszta";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // groupBoxLoadSamples
        // 
        groupBoxLoadSamples.Controls.Add(labelSamplesLoaded);
        groupBoxLoadSamples.Controls.Add(buttonLoadSamples);
        groupBoxLoadSamples.Location = new System.Drawing.Point(6, 57);
        groupBoxLoadSamples.Name = "groupBoxLoadSamples";
        groupBoxLoadSamples.Size = new System.Drawing.Size(236, 114);
        groupBoxLoadSamples.TabIndex = 2;
        groupBoxLoadSamples.TabStop = false;
        groupBoxLoadSamples.Text = "Baza próbek wzorcowych";
        // 
        // labelSamplesLoaded
        // 
        labelSamplesLoaded.Dock = System.Windows.Forms.DockStyle.Bottom;
        labelSamplesLoaded.Location = new System.Drawing.Point(3, 80);
        labelSamplesLoaded.Name = "labelSamplesLoaded";
        labelSamplesLoaded.Size = new System.Drawing.Size(230, 31);
        labelSamplesLoaded.TabIndex = 1;
        labelSamplesLoaded.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // openFileDialog1
        // 
        openFileDialog1.FileName = "openFileDialog1";
        // 
        // buttonStart
        // 
        buttonStart.Enabled = false;
        buttonStart.Location = new System.Drawing.Point(9, 181);
        buttonStart.Name = "buttonStart";
        buttonStart.Size = new System.Drawing.Size(230, 53);
        buttonStart.TabIndex = 3;
        buttonStart.Text = "Waliduj";
        buttonStart.UseVisualStyleBackColor = true;
        buttonStart.Click += buttonStart_Click;
        // 
        // groupBoxMetrics
        // 
        groupBoxMetrics.Controls.Add(radioButtonLog);
        groupBoxMetrics.Controls.Add(radioButtonCzebyszew);
        groupBoxMetrics.Controls.Add(radioButtonEuclid);
        groupBoxMetrics.Controls.Add(radioButtonManhattan);
        groupBoxMetrics.Location = new System.Drawing.Point(252, 57);
        groupBoxMetrics.Name = "groupBoxMetrics";
        groupBoxMetrics.Size = new System.Drawing.Size(149, 177);
        groupBoxMetrics.TabIndex = 4;
        groupBoxMetrics.TabStop = false;
        groupBoxMetrics.Text = "Metryki";
        // 
        // radioButtonLog
        // 
        radioButtonLog.Location = new System.Drawing.Point(7, 129);
        radioButtonLog.Name = "radioButtonLog";
        radioButtonLog.Size = new System.Drawing.Size(127, 30);
        radioButtonLog.TabIndex = 3;
        radioButtonLog.Text = "Logarytmowa";
        radioButtonLog.UseVisualStyleBackColor = true;
        radioButtonLog.CheckedChanged += radioButtonLog_CheckedChanged;
        // 
        // radioButtonCzebyszew
        // 
        radioButtonCzebyszew.Location = new System.Drawing.Point(7, 93);
        radioButtonCzebyszew.Name = "radioButtonCzebyszew";
        radioButtonCzebyszew.Size = new System.Drawing.Size(120, 30);
        radioButtonCzebyszew.TabIndex = 2;
        radioButtonCzebyszew.Text = "Czebyszewa";
        radioButtonCzebyszew.UseVisualStyleBackColor = true;
        radioButtonCzebyszew.CheckedChanged += radioButtonCzebyszew_CheckedChanged;
        // 
        // radioButtonEuclid
        // 
        radioButtonEuclid.Location = new System.Drawing.Point(7, 57);
        radioButtonEuclid.Name = "radioButtonEuclid";
        radioButtonEuclid.Size = new System.Drawing.Size(120, 30);
        radioButtonEuclid.TabIndex = 1;
        radioButtonEuclid.Text = "Euklidesowa";
        radioButtonEuclid.UseVisualStyleBackColor = true;
        radioButtonEuclid.CheckedChanged += radioButtonEuclid_CheckedChanged;
        // 
        // radioButtonManhattan
        // 
        radioButtonManhattan.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        radioButtonManhattan.Checked = true;
        radioButtonManhattan.Location = new System.Drawing.Point(7, 21);
        radioButtonManhattan.Name = "radioButtonManhattan";
        radioButtonManhattan.Size = new System.Drawing.Size(120, 30);
        radioButtonManhattan.TabIndex = 0;
        radioButtonManhattan.TabStop = true;
        radioButtonManhattan.Text = "Manhattan";
        radioButtonManhattan.UseVisualStyleBackColor = true;
        radioButtonManhattan.CheckedChanged += radioButtonManhattan_CheckedChanged;
        // 
        // numericUpDown1
        // 
        numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
        numericUpDown1.Location = new System.Drawing.Point(29, 54);
        numericUpDown1.Maximum = new decimal(new int[] { 149, 0, 0, 0 });
        numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numericUpDown1.Name = "numericUpDown1";
        numericUpDown1.Size = new System.Drawing.Size(99, 27);
        numericUpDown1.TabIndex = 5;
        numericUpDown1.Value = new decimal(new int[] { 3, 0, 0, 0 });
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(radioKTotal);
        groupBox1.Controls.Add(radioKEach);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(numericUpDown1);
        groupBox1.Location = new System.Drawing.Point(410, 57);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(158, 177);
        groupBox1.TabIndex = 6;
        groupBox1.TabStop = false;
        groupBox1.Text = "Inne";
        // 
        // radioKTotal
        // 
        radioKTotal.Checked = true;
        radioKTotal.Location = new System.Drawing.Point(24, 93);
        radioKTotal.Name = "radioKTotal";
        radioKTotal.Size = new System.Drawing.Size(104, 24);
        radioKTotal.TabIndex = 8;
        radioKTotal.TabStop = true;
        radioKTotal.Text = "K ogółem";
        radioKTotal.UseVisualStyleBackColor = true;
        radioKTotal.CheckedChanged += radioKTotal_CheckedChanged_1;
        // 
        // radioKEach
        // 
        radioKEach.Location = new System.Drawing.Point(24, 123);
        radioKEach.Name = "radioKEach";
        radioKEach.Size = new System.Drawing.Size(134, 24);
        radioKEach.TabIndex = 7;
        radioKEach.Text = "K każdej klasy";
        radioKEach.UseVisualStyleBackColor = true;
        radioKEach.CheckedChanged += radioKEach_CheckedChanged;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(29, 26);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(101, 25);
        label2.TabIndex = 6;
        label2.Text = "Parametr K:";
        // 
        // textBoxOutput
        // 
        textBoxOutput.Location = new System.Drawing.Point(9, 244);
        textBoxOutput.Multiline = true;
        textBoxOutput.Name = "textBoxOutput";
        textBoxOutput.ReadOnly = true;
        textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        textBoxOutput.Size = new System.Drawing.Size(559, 302);
        textBoxOutput.TabIndex = 7;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(575, 553);
        Controls.Add(textBoxOutput);
        Controls.Add(groupBox1);
        Controls.Add(groupBoxMetrics);
        Controls.Add(buttonStart);
        Controls.Add(groupBoxLoadSamples);
        Controls.Add(label1);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
        MaximizeBox = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "K-NN";
        groupBoxLoadSamples.ResumeLayout(false);
        groupBoxMetrics.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
        groupBox1.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.RadioButton radioKTotal;

    private System.Windows.Forms.RadioButton radioKEach;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBoxOutput;

    private System.Windows.Forms.NumericUpDown numericUpDown1;
    private System.Windows.Forms.GroupBox groupBox1;

    private System.Windows.Forms.RadioButton radioButtonEuclid;
    private System.Windows.Forms.RadioButton radioButtonCzebyszew;

    private System.Windows.Forms.RadioButton radioButtonLog;

    private System.Windows.Forms.GroupBox groupBoxMetrics;
    private System.Windows.Forms.RadioButton radioButtonManhattan;

    private System.Windows.Forms.Button buttonStart;

    private System.Windows.Forms.OpenFileDialog openFileDialog1;

    private System.Windows.Forms.Label labelSamplesLoaded;

    private System.Windows.Forms.GroupBox groupBoxLoadSamples;

    private System.Windows.Forms.Button buttonLoadSamples;
    private System.Windows.Forms.Label label1;

    #endregion
}