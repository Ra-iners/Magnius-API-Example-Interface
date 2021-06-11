## What is Magnius API?

Magnius API is an extension for Magnius that is made for people to use Magnius Module without doing extra coding.

## Installation

Watch the youtube [video](https://www.youtube.com/watch?v=mjMsRpTwDbQ) to learn how to use/install Magnius Api

## Usage

```cs
using System.Windows.Forms;
using MagniusApi;

namespace MagniusAPIForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Magnius.Start(); // This initializes the API. Without this; you cannot use Magnius API.
        }

        /// <summary>
        /// This function should usually be inside of a button, It will execute the given string, which can be something like a richTextBox, for example you'd put Magnius.Execute(RichTextBox1.Text);
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            Magnius.Execute(richTextBox1.Text);
        }

        /// <summary>
        /// This function should usually be inside of a button, It will inject the Magnius module into ROBLOX.
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            Magnius.Inject();
        }

        /// <summary>
        /// This function should usually be inside of a button, it will redirect the user to a website, where they will be able to get the key.
        /// </summary>
        private void button3_Click(object sender, EventArgs e)
        {
            Magnius.GetKey();
        }
    }
}

```

## Contributing
You can contribute to Magnius API by making / releasing nice UI's and using Magnius API while doing so! That would make me feel happy.

## Credits

Thanks to Rakion99 and
Thanks to everyone in the Credits section of the Discord.
