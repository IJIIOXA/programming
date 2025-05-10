using System;
using System.Windows.Forms;

class MyApp : Form
{
    private Label labelPrompt;
    private TextBox inputName;
    private Button greetButton;
    private Label labelGreeting;

    public MyApp()
    {
        // Метка
        labelPrompt = new Label { Text = "Введите ваше имя:", Location = new System.Drawing.Point(20, 20), AutoSize = true };

        // Поле ввода
        inputName = new TextBox { Location = new System.Drawing.Point(20, 45), Width = 200 };

        // Кнопка
        greetButton = new Button { Text = "Поздороваться", Location = new System.Drawing.Point(20, 75), Width = 200 };
        greetButton.Click += GreetButton_Click;

        // Ответ
        labelGreeting = new Label { Location = new System.Drawing.Point(20, 110), AutoSize = true };

        // Добавляем элементы на форму
        Controls.Add(labelPrompt);
        Controls.Add(inputName);
        Controls.Add(greetButton);
        Controls.Add(labelGreeting);

        // Параметры окна
        Text = "Приветствие";
        ClientSize = new System.Drawing.Size(260, 160);
    }

    private void GreetButton_Click(object sender, EventArgs e)
    {
        string name = inputName.Text.Trim();
        if (!string.IsNullOrEmpty(name))
            labelGreeting.Text = $"Привет, {name}!";
        else
            MessageBox.Show("Пожалуйста, введите имя.");
    }

    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new MyApp());
    }
}
