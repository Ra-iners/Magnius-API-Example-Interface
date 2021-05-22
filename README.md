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

        private void Form1_Load(object sender, EventArgs e)
        {
          // Other code here.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Magnius.Execute(richTextBox1.Text); // This must be inside an Execute button. It'll execute whatever is inside your text box. (NOTE: change 'richTextBox1' to your own text editor.)
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Magnius.Inject(); // This must be inside an Inject button. It'll inject Magnius Module.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Magnius.GetKey(); // This must be inside a Get Key button. It'll redirect you to the link to get the key.
        }
    }
}

```

## Contributing
You can contribute to Magnius API by making / releasing nice UI's and using Magnius API while doing so! That would make me feel happy.

## Credits

Thanks to Rakion99 and
Thanks to everyone in the Credits section of the Discord.
