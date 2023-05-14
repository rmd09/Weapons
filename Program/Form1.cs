using Weapons;
using Interactive;

namespace Program
{
    public partial class MainForm : Form
    {
        private const int MAX_CHARS_OF_13_FONT_IN_LDESCRIPTION = 300; //����������� ����������� ���-�� �������� 13 ������ � lDescription
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

            lDescription.Text = $"���: {weapon.ItemType}\n\n��������: {weapon.Description}\n\n������: {weapon.Caliber}��\n����: {weapon.Damage}\n���-�� �������� � ��������: {weapon.MagazineSize}";

            if (lDescription.Text.Length > MAX_CHARS_OF_13_FONT_IN_LDESCRIPTION)
                lDescription.Font = new Font("Segoe UI", 11.5f, FontStyle.Bold);
            else
                lDescription.Font = new Font("Segoe UI", 13, FontStyle.Bold);
        }

        private void bInteractive_Click(object sender, EventArgs e)
        {
            FormInteractive form = new FormInteractive(descritionEditor.WeaponChoosingNow, treeWeapon.SelectedNode.Text);
            form.ShowDialog();
        }
    }
}