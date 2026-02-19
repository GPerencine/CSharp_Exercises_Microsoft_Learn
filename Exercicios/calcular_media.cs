int examAssignments = 5;

string[] studentNames = { "Sophia", "Andrew", "Emma", "Logan" };

int[] sophiaScores = { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = { 90, 95, 87, 88, 96, 96 };

int[] studentScores = new int[0];

Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit");
Console.WriteLine("-----------------------------------------------------");

foreach (string student in studentNames)
{
    if (student == "Sophia")
        studentScores = sophiaScores;
    else if (student == "Andrew")
        studentScores = andrewScores;
    else if (student == "Emma")
        studentScores = emmaScores;
    else if (student == "Logan")
        studentScores = loganScores;

    int examScore = 0;
    int extraCreditScore = 0;
    int gradedAssignments = 0;

    foreach (int score in studentScores)
    {
        gradedAssignments++;

        if (gradedAssignments <= examAssignments)
            examScore += score;
        else
            extraCreditScore += score;
    }

    decimal examAverage = (decimal)examScore / examAssignments;
    decimal extraCreditPoints = extraCreditScore * 0.10m / examAssignments;
    decimal finalScore = examAverage + extraCreditPoints;

    string letterGrade;

    if (finalScore >= 97) letterGrade = "A+";
    else if (finalScore >= 93) letterGrade = "A";
    else if (finalScore >= 90) letterGrade = "A-";
    else if (finalScore >= 87) letterGrade = "B+";
    else if (finalScore >= 83) letterGrade = "B";
    else if (finalScore >= 80) letterGrade = "B-";
    else if (finalScore >= 77) letterGrade = "C+";
    else if (finalScore >= 73) letterGrade = "C";
    else if (finalScore >= 70) letterGrade = "C-";
    else if (finalScore >= 67) letterGrade = "D+";
    else if (finalScore >= 63) letterGrade = "D";
    else if (finalScore >= 60) letterGrade = "D-";
    else letterGrade = "F";

    Console.WriteLine(
        $"{student,-10}\t{examAverage:F1}\t\t{finalScore:F2}\t{letterGrade}\t{examScore / examAssignments} ({extraCreditPoints:F2} pts)"
    );
}
