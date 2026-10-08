namespace StockFlow
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            DashboardControl dashboardControl = new()
            {
                Dock = DockStyle.Fill
            };

            pnlContent.Controls.Add(dashboardControl);
        }
    }
}
