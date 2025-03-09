using System.Data;

namespace Pokemongo
{
    public partial class Form1 : Form
    {
        private List<Pokemon> pokemonsList = new List<Pokemon>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Create Pikachu object
            Pikachu pikachu = new Pikachu();
            //add Pikachu object to the list
            this.pokemonsList.Add(pikachu);
            //display the Pokemon's name and image
            this.displayPokemon(pikachu);
        }
        private void displayPokemon(Pokemon pokemon)
        {
            this.box1.Text = pokemon.getName();
            using (var ms = new MemoryStream(pokemon.getImage()))
            {
                this.pictureBox1.Image = Image.FromStream(ms);

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Pikachu pikachu = new Pikachu(); // ??????????????? Pikachu
            pikachu.Name = "Pikachu";
            pikachu.Type = Pokemon.PokemonType.Electric;


            pictureBox1.Image = pikachu.getImageAsImage();
            pictureBox1.Visible = true;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            H4.Text = "Height: " + pikachu.Height.ToString();
            W5.Text = "Weight: " + pikachu.Weight.ToString();
            HP.Text = "HP: " + pikachu.HP.ToString();
            A10.Text = "Attack: " + pikachu.Attack.ToString();
            D6.Text = "Defense: " + pikachu.Defense.ToString();
            SA7.Text = "Special Attack: " + pikachu.SpecialAttack.ToString();
            SD8.Text = "Special Defense: " + pikachu.SpecialDefense.ToString();
            SP9.Text = "Speed: " + pikachu.Speed.ToString();
            Total.Text = "Total: " + pikachu.Total.ToString();
            N1.Text = "Name: " + pikachu.Name.ToString();
            T2.Text = "Type: " + pikachu.Type.ToString();

            N1.Visible = true;
            T2.Visible = true;
            S3.Visible = true;
            H4.Visible = true;
            W5.Visible = true;
            HP.Visible = true;
            A10.Visible = true;
            D6.Visible = true;
            A10.Visible = true;
            D6.Visible = true;
            SD8.Visible = true;
            SA7.Visible = true;
            SP9.Visible = true;
            Total.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void label1_Click_4(object sender, EventArgs e)
        {

        }

        private void box2_Click(object sender, EventArgs e)
        {
            Metamon metamon = new Metamon();

            pictureBox1.Image = metamon.getImageAsImage();
            pictureBox1.Visible = true;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            H4.Text = "Height: " + metamon.Height.ToString();
            W5.Text = "Weight: " + metamon.Weight.ToString();
            HP.Text = "HP: " + metamon.HP.ToString();
            A10.Text = "Attack: " + metamon.Attack.ToString();
            D6.Text = "Defense: " + metamon.Defense.ToString();
            SA7.Text = "Special Attack: " + metamon.SpecialAttack.ToString();
            SD8.Text = "Special Defense: " + metamon.SpecialDefense.ToString();
            SP9.Text = "Speed: " + metamon.Speed.ToString();
            Total.Text = "Total: " + metamon.Total.ToString();
            N1.Text = "Name: " + metamon.Name.ToString();
            T2.Text = "Type: " + metamon.Type.ToString();


            N1.Visible = true;
            T2.Visible = true;
            S3.Visible = true;
            H4.Visible = true;
            W5.Visible = true;
            HP.Visible = true;
            A10.Visible = true;
            D6.Visible = true;
            SD8.Visible = true;
            SA7.Visible = true;
            SP9.Visible = true;
            Total.Visible = true;
        }

        private void W5_Click(object sender, EventArgs e)
        {

        }

        private void box3_Click(object sender, EventArgs e)
        {
            Mew mew = new Mew();

            pictureBox1.Image = mew.getImageAsImage();
            pictureBox1.Visible = true;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            H4.Text = "Height: " + mew.Height.ToString();
            W5.Text = "Weight: " + mew.Weight.ToString();
            HP.Text = "HP: " + mew.HP.ToString();
            A10.Text = "Attack: " + mew.Attack.ToString();
            D6.Text = "Defense: " + mew.Defense.ToString();
            SA7.Text = "Special Attack: " + mew.SpecialAttack.ToString();
            SD8.Text = "Special Defense: " + mew.SpecialDefense.ToString();
            SP9.Text = "Speed: " + mew.Speed.ToString();
            Total.Text = "Total: " + mew.Total.ToString();
            N1.Text = "Name: " + mew.Name.ToString();
            T2.Text = "Type: " + mew.Type.ToString();


            N1.Visible = true;
            T2.Visible = true;
            S3.Visible = true;
            H4.Visible = true;
            W5.Visible = true;
            HP.Visible = true;
            A10.Visible = true;
            D6.Visible = true;
            SD8.Visible = true;
            SA7.Visible = true;
            SP9.Visible = true;
            Total.Visible = true;
        }

        private void box4_Click(object sender, EventArgs e)
        {
            mewtwo mewtwo = new mewtwo();

            pictureBox1.Image = mewtwo.getImageAsImage();
            pictureBox1.Visible = true;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            H4.Text = "Height: " + mewtwo.Height.ToString();
            W5.Text = "Weight: " + mewtwo.Weight.ToString();
            HP.Text = "HP: " + mewtwo.HP.ToString();
            A10.Text = "Attack: " + mewtwo.Attack.ToString();
            D6.Text = "Defense: " + mewtwo.Defense.ToString();
            SA7.Text = "Special Attack: " + mewtwo.SpecialAttack.ToString();
            SD8.Text = "Special Defense: " + mewtwo.SpecialDefense.ToString();
            SP9.Text = "Speed: " + mewtwo.Speed.ToString();
            Total.Text = "Total: " + mewtwo.Total.ToString();
            N1.Text = "Name: " + mewtwo.Name.ToString();
            T2.Text = "Type: " + mewtwo.Type.ToString();


            N1.Visible = true;
            T2.Visible = true;
            S3.Visible = true;
            H4.Visible = true;
            W5.Visible = true;
            HP.Visible = true;
            A10.Visible = true;
            D6.Visible = true;
            SD8.Visible = true;
            SA7.Visible = true;
            SP9.Visible = true;
            Total.Visible = true;
        }

        private void box5_Click(object sender, EventArgs e)
        {
            Picashi picashi = new Picashi();

            pictureBox1.Image = picashi.getImageAsImage();
            pictureBox1.Visible = true;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            H4.Text = "Height: " + picashi.Height.ToString();
            W5.Text = "Weight: " + picashi.Weight.ToString();
            HP.Text = "HP: " + picashi.HP.ToString();
            A10.Text = "Attack: " + picashi.Attack.ToString();
            D6.Text = "Defense: " + picashi.Defense.ToString();
            SA7.Text = "Special Attack: " + picashi.SpecialAttack.ToString();
            SD8.Text = "Special Defense: " + picashi.SpecialDefense.ToString();
            SP9.Text = "Speed: " + picashi.Speed.ToString();
            Total.Text = "Total: " + picashi.Total.ToString();
            N1.Text = "Name: " + picashi.Name.ToString();
            T2.Text = "Type: " + picashi.Type.ToString();


            N1.Visible = true;
            T2.Visible = true;
            S3.Visible = true;
            H4.Visible = true;
            W5.Visible = true;
            HP.Visible = true;
            A10.Visible = true;
            D6.Visible = true;
            SD8.Visible = true;
            SA7.Visible = true;
            SP9.Visible = true;
            Total.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            jirachi jirachi = new jirachi();

            pictureBox1.Image = jirachi.getImageAsImage();
            pictureBox1.Visible = true;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            H4.Text = "Height: " + jirachi.Height.ToString();
            W5.Text = "Weight: " + jirachi.Weight.ToString();
            HP.Text = "HP: " + jirachi.HP.ToString();
            A10.Text = "Attack: " + jirachi.Attack.ToString();
            D6.Text = "Defense: " + jirachi.Defense.ToString();
            SA7.Text = "Special Attack: " + jirachi.SpecialAttack.ToString();
            SD8.Text = "Special Defense: " + jirachi.SpecialDefense.ToString();
            SP9.Text = "Speed: " + jirachi.Speed.ToString();
            Total.Text = "Total: " + jirachi.Total.ToString();
            N1.Text = "Name: " + jirachi.Name.ToString();
            T2.Text = "Type: " + jirachi.Type.ToString();


            N1.Visible = true;
            T2.Visible = true;
            S3.Visible = true;
            H4.Visible = true;
            W5.Visible = true;
            HP.Visible = true;
            A10.Visible = true;
            D6.Visible = true;
            SD8.Visible = true;
            SA7.Visible = true;
            SP9.Visible = true;
            Total.Visible = true;
        }
    }
}
