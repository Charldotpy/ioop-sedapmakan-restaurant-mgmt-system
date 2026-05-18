using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using _123;
using Manager;

namespace showmembers
{
    public partial class Form1 : Form
    {
        public List<UserControl> pages = new List<UserControl>();
        public Stack<int> backStack = new Stack<int>();
        public Stack<int> forwardStack = new Stack<int>();
        public int currentPageIndex = -1;
        public UserControl currentPage = null;

        private User_Login userLogin;
        private User_Signup userSignup;

        public Form1()
        {
            InitializeComponent();
            backbtn.Enabled = false;
            nextbn.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userLogin = new User_Login(this);
            userSignup = new User_Signup();

            userLogin.SignUpRequested += (s, e) => NavigateToPage(1);

            pages.Add(userLogin);
            pages.Add(userSignup);
            ShowPageAt(0);
        }

        public void ShowPageAt(int index)
        {
            if (index < 0 || index >= pages.Count)
                return;

            if (currentPage != null)
                mainPnl.Controls.Remove(currentPage);

            currentPageIndex = index;
            currentPage = pages[index];
            currentPage.Dock = DockStyle.Fill;
            mainPnl.Controls.Add(currentPage);
            currentPage.BringToFront();

            backbtn.Enabled = backStack.Count > 0;
            nextbn.Enabled = forwardStack.Count > 0;
        }

        public void NavigateToPage(int newIndex)
        {
            if (newIndex < 0 || newIndex >= pages.Count)
                return;

            if (currentPageIndex >= 0)
                backStack.Push(currentPageIndex);

            forwardStack.Clear();
            ShowPageAt(newIndex);
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            if (backStack.Count == 0)
                return;

            forwardStack.Push(currentPageIndex);
            int previousIndex = backStack.Pop();
            ShowPageAt(previousIndex);
        }

        private void nextbn_Click(object sender, EventArgs e)
        {
            if (forwardStack.Count == 0)
                return;

            backStack.Push(currentPageIndex);
            int forwardIndex = forwardStack.Pop();
            ShowPageAt(forwardIndex);
        }
    }
}