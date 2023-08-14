// See https://aka.ms/new-console-template for more information
using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

var questions = new string[5];
var answwers = new int[5];
var diagnoses = new string[6];

diagnoses[0] = "Идиот";
diagnoses[1] = "Кретин";
diagnoses[2] = "Дурак";
diagnoses[3] = "Нормальный";
diagnoses[4] = "Талант";
diagnoses[5] = "Гений";


questions[0] = "Сколько будет два плюс два умножить на два?";
questions[1] = "Бревно надо распелить на 10 частей сколько нужно сделать распилов?";
questions[2] = "На двух руках 10 пальцев. Сколько пальцев на 5 руках?";
questions[3] = "Укол делают каждые полчаса, сколько потребуется времени для 3-х уколов?";
questions[4] = "Пять свечей горело, две потухло. Сколько свечей осталоcь?";

answwers[0] = 6;
answwers[1] = 9;
answwers[2] = 25;
answwers[3] = 60;
answwers[4] = 2;



int counterRigthAnswers = 0;

for (int i = 0; i < questions.Length; i++)
{
    Console.WriteLine($"Вопрос № {i + 1}: {questions[i]}");

    var rigthAnswer = answwers[i];
    var userAnswer = int.Parse(Console.ReadLine());

    if (userAnswer == rigthAnswer)
    {
        counterRigthAnswers++;
    }
}

Console.WriteLine($"Количество правильных ответов: {counterRigthAnswers}.\n" +
    $"Вы - {diagnoses[counterRigthAnswers]}!");


