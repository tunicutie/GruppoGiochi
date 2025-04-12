using System.Reflection.Metadata.Ecma335;

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
        listSettimane = new ListBox[4];

        this.MainMenuStrip = menuStrip;
        this.components = new System.ComponentModel.Container();
        this.FormBorderStyle = FormBorderStyle.None;
        this.WindowState = FormWindowState.Maximized;
        this.ClientSize = new System.Drawing.Size(1920, 1080);
        this.Text = "Form1";
        menuAnimatori = new System.Windows.Forms.ToolStripMenuItem();
        menuSettimane = new System.Windows.Forms.ToolStripMenuItem();
        menuStrip.SuspendLayout();
        //
        // menuAnimatori
        //
        menuAnimatori.AutoSize = false;
        menuAnimatori.Name = "menuAnimatori";
        menuAnimatori.Size = new Size(Size.Width / 4, Height / 2);
        menuAnimatori.Alignment = ToolStripItemAlignment.Right;
        menuAnimatori.BackColor = Color.DarkGray;
        menuAnimatori.Text = "Gestione Animatori";
        menuAnimatori.Click += new System.EventHandler(this.menuAnimatori_Click);
        //
        // menuSettimane
        //
        menuSettimane.AutoSize = false;
        menuSettimane.Name = "menuSettimane";
        menuSettimane.Size = new Size(Size.Width / 4, Height / 2);
        menuSettimane.Anchor = AnchorStyles.Right;
        menuSettimane.Alignment = ToolStripItemAlignment.Left;
        menuSettimane.BackColor = Color.DarkGray;
        menuSettimane.Text = "Settimane";
        menuSettimane.Click += new System.EventHandler(this.menuSettimane_Click);
        //
        // menuStrip
        //
        menuStrip.AutoSize = false;
        menuStrip.Location = new System.Drawing.Point(0, 0);
        menuStrip.Name = "menuStrip";
        menuStrip.Dock = DockStyle.Fill;
        menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { menuAnimatori, menuSettimane });
        // listSettimane
        Point startpos = new Point(20, 20);
        for (int i = 0; i < 4; i++)
        {
            listSettimane[i] = new ListBox();
            listSettimane[i].Size = new Size(ClientSize.Width / 4 - 40, Height - 40);
            listSettimane[i].Location = new Point(startpos.X, startpos.Y);
            listSettimane[i].Name = $"listSettimana{i + 1}";
            Controls.Add(listSettimane[i]);
            startpos.X += listSettimane[i].Width + 20;
        }

        this.Controls.Add(menuStrip);
        this.menuStrip.ResumeLayout(false);
        this.menuStrip.PerformLayout();
        this.PerformLayout();
    }
    
    #endregion
    public MenuStrip menuStrip;
    public ToolStripMenuItem menuAnimatori;
    public ListBox[] listSettimane;
    public ToolStripMenuItem menuSettimane;
}
