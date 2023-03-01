namespace Assigment3
{
    public partial class assig3 : Form
    {

        public assig3()
        {
            InitializeComponent();
        }

        private void assig3_Load(object sender, EventArgs e)
        {
            lblErroMsg.Text = "";
            UpdateControls(AppState.AwaitingPac);

            try
            {
                LoadPacInListBox();
            }
            catch (Exception ex)
            {
                SetErrorMessage("There was a problem loading Pacients from the file.");
            }          
        }

        private void btnStartNewNote_Click(object sender, EventArgs e)
        {
            UpdateControls(AppState.AddingPac);
            _currentPac = new Pac();
            _currentPac.PacId = _pacientManager.GetNextPacId();
            txtNote.Text = $"{_currentPac.PacId}";
        }


        private void btnAddNote_Click(object sender, EventArgs e)
        {
            HandleAddOrEdit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string newProblem = txtAdd.Text;
            if (string.IsNullOrWhiteSpace(newProblem))
            {
                SetErrorMessage("Please input a new problem \n");               
            }
            else
            {
                txtProblem.Text = newProblem;
                txtAdd.Text = "";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            HandleAddOrEdit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_currentPac == null)
            {
                SetErrorMessage("Please select or create a new pacient first.");
                return;
            }

            _pacientManager.DeletePacById(_currentPac.PacId);
            LoadPacInListBox();
            UpdateControls(AppState.AwaitingPac);
        }

        private void listBoxPacient_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listBoxPacient.SelectedIndex;
            if (selectedIndex == -1)
                return;

            UpdateControls(AppState.EditingPac);
            LoadAPacBySelectedIndex(selectedIndex);
        }
        private void LoadAPacBySelectedIndex(int selectedIndex)
        {
            Pac? selectedPac = listBoxPacient.Items[selectedIndex] as Pac;
            if (selectedPac != null)
            {
                _currentPac = _pacientManager.GetPacById(selectedPac.PacId);
                txtNote.Text = _currentPac.PacId.ToString();
                txtPacName.Text = _currentPac.PacName;
                calender.Value = _currentPac.Birthday;    
                txtProblem.Text = _currentPac.Problem;
                txtWriteNote.Text = _currentPac.Note.Replace(';', '\n');
            }
        }

        private void HandleAddOrEdit()
        {
            if (_currentPac == null)
            {
                SetErrorMessage("Please select or create a new Pacient first.");
                return;
            }

            string errMsg = "";
            string pacName = txtPacName.Text.Trim();
            if (string.IsNullOrEmpty(pacName))
                errMsg += "Please input the pac name.\n";
            if (calender.Value > DateTime.Now)
            {
                errMsg += ("The birthday can no be in the future\n");
            }
            string bloodPressure = txtWriteNote.Text;
            if (!string.IsNullOrWhiteSpace(bloodPressure))
            {
                if (!BPmatch.IsBPmatch(ref bloodPressure))
                {
                    errMsg += ("The Blood Presure must be given in the format BP 120/80 \n");
                }
                else
                {
                    string bpTest = bloodPressure.Insert(bloodPressure.IndexOf('/') + 3, "|");
                    string[] bloodPressureArray = bpTest.Split('|');
                    txtBP.Text = bloodPressureArray[0];
                }
            }
            else
            {
                errMsg += ("Please input a note content\n");
            }


            if (errMsg == "")
            {
                _currentPac.PacName = pacName;
                _currentPac.Birthday = calender.Value;
                _currentPac.Note = txtWriteNote.Text;

                if (_currentAppState == AppState.AddingPac)
                {
                    _pacientManager.AddPac(_currentPac);

                    listBoxPacient.Items.Add(_currentPac);
                    int currCount = listBoxPacient.Items.Count;
                    listBoxPacient.SelectedIndex = currCount - 1;

                    UpdateControls(AppState.EditingPac);
                    SetInfoMessage("New album was added.");
                }
                else if (_currentAppState == AppState.EditingPac)
                {
                    _pacientManager.UpdatePac(_currentPac);
                    LoadPacInListBox();
                    SetInfoMessage("Album was updated.");
                }
            }
            else
            {
                SetErrorMessage(errMsg);
            }
        }
        private void LoadPacInListBox()
        {
            listBoxPacient.Items.Clear();

            List<Pac> pacients = _pacientManager.GetAllPac();
            foreach (Pac pac in pacients)
            {
                listBoxPacient.Items.Add(pac);
            }
        }
        private void UpdateControls(AppState newState)
        {
            _currentAppState = newState;

            if (_currentAppState == AppState.AwaitingPac)
            {
                listBoxPacient.SelectedIndex = -1;

                txtNote.Text = "";
                txtPacName.Text = "";
                calender.Value = DateTime.Now;
                txtProblem.Text = "";
                txtWriteNote.Text = "";
                txtBP.Text = "";

                txtNote.ReadOnly = true;
                btnAdd.Enabled = false;
                btnAddNote.Enabled = false;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                txtPacName.Enabled = false;
                calender.Enabled = false;
                txtAdd.Enabled = false;
                txtProblem.Enabled = false;
                txtWriteNote.Enabled = false;

            }
            else if (_currentAppState == AppState.AddingPac)
            {
                txtPacName.Text = "";
                txtNote.Text = "";
                txtProblem.Text = "";
                txtAdd.Text = "";
                txtWriteNote.Text = "";
                txtBP.Text = "";

                txtPacName.Enabled = true;
                calender.Enabled = true;
                txtAdd.Enabled = true;
                txtWriteNote.Enabled = true;
                btnAddNote.Enabled = true;
                btnAdd.Enabled = true;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;

            }
            else if (_currentAppState == AppState.EditingPac)
            {
                lblErroMsg.Text = "";

                txtPacName.Enabled = true;
                txtNote.Enabled = true;
                txtProblem.Enabled = true;
                txtAdd.Enabled = true;
                txtWriteNote.Enabled = true;
                calender.Enabled = true;
                btnAddNote.Enabled = false;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                btnAdd.Enabled = true;
            }
        }
        private void SetErrorMessage(string msg)
        {
            lblErroMsg.ForeColor = Color.Red;
            lblErroMsg.Text = msg;
        }

        private void SetInfoMessage(string msg)
        {
            lblErroMsg.ForeColor = Color.Black;
            lblTitle.Text = msg;
        }
        private Pac? _currentPac = null;
        private enum AppState { AwaitingPac, AddingPac, EditingPac };
        private AppState _currentAppState = AppState.AwaitingPac;
        private PacManagement _pacientManager = new PacManagement();
    }
}