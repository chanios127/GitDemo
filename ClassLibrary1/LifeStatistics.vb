Public Class LifeStatistics
    ' ����� ������ ����
    Private Const MaxLifeExpectancy As Integer = 120

    ' ���̸� �Է¹޾� ������ ��� ������ ����ϴ� �Լ�
    Public Function CalculateRemainingLifeExpectancy(age As Integer) As Integer
        If age >= MaxLifeExpectancy Then
            Return 0 ' ���̰� �������� �Ѿ��� ���, ���� ������ 0
        End If
        Return MaxLifeExpectancy - age
    End Function

    ' ������ �Է¹޾� ��� ���� ��� ����, ����, ������ �з��ϴ� �Լ�
    Public Function PredictIncomeLevel(salary As Double) As String
        Dim avgSalary As Double = 50000 ' ��� ������ 50,000���� ���� (���� ��)
        If salary > avgSalary * 1.5 Then
            Return "High Income"
        ElseIf salary > avgSalary * 0.75 Then
            Return "Middle Income"
        Else
            Return "Low Income"
        End If
    End Function

    ' ������ �Է¹޾� �ູ���� �߷��ϴ� �Լ� (������ ���� ���)
    Public Function PredictHappinessByJob(job As String) As Double
        Select Case job.ToLower()
            Case "doctor", "engineer", "teacher"
                Return 80 ' ������ ���� �ູ�� (0 ~ 100)
            Case "artist", "musician"
                Return 70
            Case "student"
                Return 60
            Case Else
                Return 50 ' ��Ÿ ������ ��� �⺻��
        End Select
    End Function

    ' ���̿� ������ �޾� �ູ���� ����ϴ� �Լ�
    Public Function CalculateHappiness(age As Integer, job As String) As Double
        Dim baseHappiness As Double = PredictHappinessByJob(job)
        Dim ageFactor As Double = (MaxLifeExpectancy - age) / MaxLifeExpectancy * 100
        ' ���̰� ���������� �ູ���� ���� (�ܼ��� ���� �˰���)
        Return Math.Max(0, baseHappiness * ageFactor / 100)
    End Function

    ' ��ü���� ���� �����͸� ����ϴ� �Լ�
    Public Sub DisplayLifeSummary(name As String, age As Integer, salary As Double, job As String)
        Console.WriteLine("Life Summary for " & name & ":")
        Console.WriteLine("------------------------------------------------")

        ' ���� ��� ���� ���
        Dim remainingYears As Integer = CalculateRemainingLifeExpectancy(age)
        Console.WriteLine("Remaining Life Expectancy: " & remainingYears & " years")

        ' ���� �з� ���
        Dim incomeLevel As String = PredictIncomeLevel(salary)
        Console.WriteLine("Income Level: " & incomeLevel)

        ' �ູ�� ���
        Dim happiness As Double = CalculateHappiness(age, job)
        Console.WriteLine("Predicted Happiness Level: " & happiness & " out of 100")

        Console.WriteLine("------------------------------------------------")
    End Sub
End Class
