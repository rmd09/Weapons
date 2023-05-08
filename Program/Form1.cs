using Weapons;
using Interactive;

namespace Program
{
    public partial class MainForm : Form
    {
        private DescritionEditor descritionEditor;
        private bool isWeaponChoosed = false;

        public MainForm()
        {
            InitializeComponent();

            descritionEditor = new DescritionEditor();
        }

        private void treeWeapon_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Weapon weapon = descritionEditor.GetWeapon(e.Node.Name);

            if (weapon == null)
                return;

            if (!isWeaponChoosed)
            {
                FirstChoseWeapon();
                isWeaponChoosed = true;
            }

            SetDescription(weapon, e.Node.Text);
        }

        private void FirstChoseWeapon()
        {
            lChoose.Visible = false;
            bInteractive.Enabled = true;
        }

        private void SetDescription(Weapon weapon, string name)
        {
            groupDescription.Text = name;

            lDescription.Text = $"���: {weapon.ItemType}\n\n��������: {weapon.Description}\n\n������: {weapon.Caliber}��";
        }

        private void bInteractive_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
        }
    }
}