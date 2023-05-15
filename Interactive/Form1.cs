using Weapons;

namespace Interactive
{
    public partial class FormInteractive : Form
    {
        private Weapon weapon;
        private Magazine magazine;

        public FormInteractive(Weapon weapon)
        {
            InitializeComponent();

            this.weapon = weapon;
            this.Text = $"����������: {weapon.Name}";

            UpdateLabels();
            weapon.Shooting += Shoot;
        }

        private void UpdateLabels()
        {
            lState.Text = $"�������: {(weapon.IsThereMagazine ? "����" : "���")}\n���-�� ��������: {weapon.NumberOfPatrons}\n�����������: {(weapon.IsRecharged ? "��" : "���")}\n���������������: {(weapon.IsAutoRechargable ? "��" : "���")}\n����: {weapon.Damage}\n������ ��������: {weapon.MagazineSize}";
            lMagazine.Text = magazine == null ? "���" : $"���-�� ��������: {magazine.MagazineSize}\n��� ��������: {Patron.GetTypePatronName(magazine.TypePatron)}";
        }

        private void bNewMagazine_Click(object sender, EventArgs e)
        {
            if (magazine != null)
            {
                MessageBox.Show("������� ��� ������!", "��������������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            magazine = new Magazine(weapon.MagazineSize, weapon.TypePatron, weapon.Caliber);
            UpdateLabels();
        }

        private void bInsertMagazine_Click(object sender, EventArgs e)
        {
            if (magazine == null)
            {
                MessageBox.Show("� ������ ��� ��������!", "��������������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (weapon.IsThereMagazine)
            {
                MessageBox.Show("� ������ ��� ���� �������!", "��������������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            weapon.InsertMagazine(magazine);
            magazine = null;
            UpdateLabels();
        }

        private void bTakeMagazine_Click(object sender, EventArgs e)
        {
            if (!weapon.IsThereMagazine)
            {
                MessageBox.Show("� ������ ��� ��������!", "��������������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            weapon.TakeMagazine();
            UpdateLabels();
        }

        private void bRecharge_Click(object sender, EventArgs e)
        {
            weapon.Recharge();
            UpdateLabels();
        }

        private void bShoot_Click(object sender, EventArgs e)
        {
            if (weapon.NumberOfPatrons <= 0)
            {
                MessageBox.Show("��� ��������!", "��������������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            weapon.Shoot();
            UpdateLabels();
        }

        private void Shoot(object sender, ShootingArgs e)
        {
            MessageBox.Show($"������ - {weapon.Name}\n��� �������: {Patron.GetTypePatronName(weapon.TypePatron)}\n����: {weapon.Damage}", "�������!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}