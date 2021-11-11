using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ChuckNorrisAPI; 

namespace Muhammed_ali_is_the_better_fighter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            ChuckNorrisClient client = new ChuckNorrisClient();
            Joke joke = await ChuckNorrisClient.GetRandomJoke();


            jokeText.Text = joke.JokeText;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            IEnumerable<string> categories = await ChuckNorrisClient.GetCategories();
            foreach (var B in categories)
            {
                Box.Items.Add(B); 
            }
        }
    }
}
