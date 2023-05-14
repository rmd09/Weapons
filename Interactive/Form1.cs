using Weapons;

namespace Interactive
{
    public partial class FormInteractive : Form
    {
        private Weapon weapon;

        public FormInteractive(Weapon weapon, string name)
        {
            InitializeComponent();

            this.weapon = weapon;
            this.Text = $"����������: {name}";
            UpdateLState();
        }

        private void UpdateLState()
        {
            lState.Text = $"\n�������: {(weapon.IsThereMagazine ? "����" : "���")}\n���-�� ��������: {weapon.NumberOfPatrons}\n�����������: {(weapon.IsRecharged ? "��" : "���")}";
        }
    }
}