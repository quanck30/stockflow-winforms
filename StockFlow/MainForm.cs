namespace StockFlow
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // 初期画面としてダッシュボードを表示する
            ShowPage(new DashboardControl(), "ダッシュボード");
            SetActiveButton(btnDashboard);
        }

        /// <summary>
        /// 指定された画面をメインコンテンツ領域に表示する。
        /// </summary>
        /// <param name="page">表示する画面</param>
        /// <param name="title">画面のタイトル</param>
        private void ShowPage(UserControl page, string title)
        {
            // 現在表示されている画面を取得する
            Control[] oldControls = pnlContent.Controls.Cast<Control>().ToArray();

            // 古い画面を取り除き、リソースを解放する
            foreach (Control control in oldControls) { 
               pnlContent.Controls.Remove(control);
                control.Dispose();
            }

            // 新しい画面を表示する
            page.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(page);

            // ヘッダーのタイトルを更新する
            lblPageTitle.Text = title;
        }


        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowPage(new DashboardControl(), "ダッシュボード");
            SetActiveButton((Button)sender);
        }

        /// <summary>
        /// 選択されたメニューボタンの背景色を変更する。
        /// </summary>
        private void SetActiveButton(Button activeButton)
        {
            Button[] menuButtons =
            {
                btnDashboard,
                btnProducts,
                btnStockIn,
                btnStockOut,
                btnHistory
            };

            // 全ボタンの背景色を初期状態に戻す
            foreach (Button button in menuButtons)
            {
                button.BackColor = Color.FromArgb(32, 44, 61);
            }

            // 選択中のボタンを強調表示する
            activeButton.BackColor = Color.FromArgb(52, 70, 95);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ShowPage(new ProductControl(), "商品管理");

            SetActiveButton((Button)sender);
        }
    }
}
