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
            this.Text = $"Интерактив: {name}";
            UpdateLState();
        }

        private void UpdateLState()
        {
            lState.Text = $"\nМагазин: {(weapon.IsThereMagazine ? "Есть" : "Нет")}\nКол-во патронов: {weapon.NumberOfPatrons}\nПерезаряжен: {(weapon.IsRecharged ? "Да" : "Нет")}";
        }
    }
}