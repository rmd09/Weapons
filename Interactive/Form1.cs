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
            this.Text = $"Интерактив: {weapon.Name}";

            UpdateLabels();
            weapon.Shooting += Shoot;
        }

        private void UpdateLabels()
        {
            lState.Text = $"Магазин: {(weapon.IsThereMagazine ? "Есть" : "Нет")}\nКол-во патронов: {weapon.NumberOfPatrons}\nПерезаряжен: {(weapon.IsRecharged ? "Да" : "Нет")}\nАвтоперезарядка: {(weapon.IsAutoRechargable ? "Да" : "Нет")}\nУрон: {weapon.Damage}\nРазмер магазина: {weapon.MagazineSize}";
            lMagazine.Text = magazine == null ? "Нет" : $"Кол-во патронов: {magazine.MagazineSize}\nТип патронов: {Patron.GetTypePatronName(magazine.TypePatron)}";
        }

        private void bNewMagazine_Click(object sender, EventArgs e)
        {
            if (magazine != null)
            {
                MessageBox.Show("Магазин уже создан!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            magazine = new Magazine(weapon.MagazineSize, weapon.TypePatron, weapon.Caliber);
            UpdateLabels();
        }

        private void bInsertMagazine_Click(object sender, EventArgs e)
        {
            if (magazine == null)
            {
                MessageBox.Show("У игрока нет магазина!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (weapon.IsThereMagazine)
            {
                MessageBox.Show("В оружии уже есть магазин!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("В оружии нет магазина!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Нет патронов!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            weapon.Shoot();
            UpdateLabels();
        }

        private void Shoot(object sender, ShootingArgs e)
        {
            MessageBox.Show($"Оружие - {weapon.Name}\nТип патрона: {Patron.GetTypePatronName(weapon.TypePatron)}\nУрон: {weapon.Damage}", "Выстрел!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}