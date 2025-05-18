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
        buttonLoadSamples = new Button();
        label1 = new Label();
        groupBoxLoadSamples = new GroupBox();
        labelSamplesLoaded = new Label();
        openFileDialog1 = new OpenFileDialog();
        groupBoxLoadSamples.SuspendLayout();
        SuspendLayout();
        // 
        // buttonLoadSamples
        // 
        buttonLoadSamples.Dock = DockStyle.Top;
        buttonLoadSamples.Location = new Point(3, 23);
        buttonLoadSamples.Margin = new Padding(10);
        buttonLoadSamples.Name = "buttonLoadSamples";
        buttonLoadSamples.Size = new Size(230, 50);
        buttonLoadSamples.TabIndex = 0;
        buttonLoadSamples.Text = "Wczytaj";
        buttonLoadSamples.UseVisualStyleBackColor = true;
        buttonLoadSamples.Click += buttonLoadSamples_Click;
        // 
        // label1
        // 
        label1.Font = new Font("Segoe UI", 11F);
        label1.Location = new Point(-11, 0);
        label1.Name = "label1";
        label1.Size = new Size(804, 54);
        label1.TabIndex = 1;
        label1.Text = "Klasyfikator k-nn, walidacja 1 vs reszta";
        label1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // groupBoxLoadSamples
        // 
        groupBoxLoadSamples.Controls.Add(labelSamplesLoaded);
        groupBoxLoadSamples.Controls.Add(buttonLoadSamples);
        groupBoxLoadSamples.Location = new Point(6, 57);
        groupBoxLoadSamples.Name = "groupBoxLoadSamples";
        groupBoxLoadSamples.Size = new Size(236, 114);
        groupBoxLoadSamples.TabIndex = 2;
        groupBoxLoadSamples.TabStop = false;
        groupBoxLoadSamples.Text = "Baza próbek wzorcowych";
        // 
        // labelSamplesLoaded
        // 
        labelSamplesLoaded.Dock = DockStyle.Bottom;
        labelSamplesLoaded.Location = new Point(3, 80);
        labelSamplesLoaded.Name = "labelSamplesLoaded";
        labelSamplesLoaded.Size = new Size(230, 31);
        labelSamplesLoaded.TabIndex = 1;
        labelSamplesLoaded.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // openFileDialog1
        // 
        openFileDialog1.FileName = "openFileDialog1";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(782, 553);
        Controls.Add(groupBoxLoadSamples);
        Controls.Add(label1);
        FormBorderStyle = FormBorderStyle.Fixed3D;
        MaximizeBox = false;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "K-NN";
        groupBoxLoadSamples.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.OpenFileDialog openFileDialog1;

    private System.Windows.Forms.Label labelSamplesLoaded;

    private System.Windows.Forms.GroupBox groupBoxLoadSamples;

    private System.Windows.Forms.Button buttonLoadSamples;
    private System.Windows.Forms.Label label1;

    #endregion
}