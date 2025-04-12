namespace GruppoGiochi;

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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        menuStrip = new System.Windows.Forms.MenuStrip();
        menuAnimatori = new System.Windows.Forms.ToolStripMenuItem();
        menuSettimane = new System.Windows.Forms.ToolStripMenuItem();
        menuStrip.SuspendLayout();
        //
        // menuStrip
        //
        menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { menuAnimatori, menuSettimane });
        menuStrip.Location = new System.Drawing.Point(0, 0);
        menuStrip.Name = "menuStrip";
        menuStrip.Size = new System.Drawing.Size(ClientSize.Width / 4, ClientSize.Height);
        //
        // menuAnimatori
        //
        menuAnimatori.Name = "menuAnimatori"
        menuAnimatori.Size = new Size(ClientSize.Width / 4, 25);
        menuAnimatori.Text = "Gestione Animatori";
        //
        // menuSettimane
        //
        menuAnimatori.Name = "menuAnimatori"
        menuAnimatori.Size = new Size(ClientSize.Width / 4, 25);
        menuAnimatori.Text = "Gestione Animatori";
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(1920, 1080);
        this.Text = "Form1";
    }

    public MenuStrip menuStrip;
    public toolStripMenuItem menuAnimatori;
    public toolStripMenuItem menuSettimane;

    #endregion
}
