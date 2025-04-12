namespace GruppoGiochi;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        HideAnimatori();
        HideSettimane();
    }

    private void HideSettimane()
    {
        foreach (ListBox listbox in listSettimane)
        {
            listbox.Visible = false;
        }
    }
    
    private void ShowSettimane()
    {
        foreach (ListBox listbox in listSettimane)
        {
            listbox.Visible = true;
        }
    }

    private void HideAnimatori()
    {
    }

    private void ShowAnimatori()
    {
    }

    private void menuAnimatori_Click(object sender, EventArgs e)
    {
        ShowAnimatori();
    }

    private void menuSettimane_Click(object sender, EventArgs e)
    {
        ShowSettimane();
    }

    
}
