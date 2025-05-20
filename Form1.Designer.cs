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
        groupBoxLoadSamples.SuspendLayout();
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
        label1.Size = new System.Drawing.Size(804, 54);
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
        buttonStart.Location = new System.Drawing.Point(298, 84);
        buttonStart.Name = "buttonStart";
        buttonStart.Size = new System.Drawing.Size(193, 53);
        buttonStart.TabIndex = 3;
        buttonStart.Text = "Start";
        buttonStart.UseVisualStyleBackColor = true;
        buttonStart.Click += buttonStart_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(782, 553);
        Controls.Add(buttonStart);
        Controls.Add(groupBoxLoadSamples);
        Controls.Add(label1);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
        MaximizeBox = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "K-NN";
        groupBoxLoadSamples.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button buttonStart;

    private System.Windows.Forms.OpenFileDialog openFileDialog1;

    private System.Windows.Forms.Label labelSamplesLoaded;

    private System.Windows.Forms.GroupBox groupBoxLoadSamples;

    private System.Windows.Forms.Button buttonLoadSamples;
    private System.Windows.Forms.Label label1;

    #endregion
}