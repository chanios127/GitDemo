Public Class LifeStatistics
    ' 상수로 기대수명 설정
    Private Const MaxLifeExpectancy As Integer = 120

    ' 나이를 입력받아 나머지 기대 수명을 계산하는 함수
    Public Function CalculateRemainingLifeExpectancy(age As Integer) As Integer
        If age >= MaxLifeExpectancy Then
            Return 0 ' 나이가 기대수명을 넘었을 경우, 남은 수명은 0
        End If
        Return MaxLifeExpectancy - age
    End Function

    ' 연봉을 입력받아 평균 연봉 대비 상위, 중위, 하위로 분류하는 함수
    Public Function PredictIncomeLevel(salary As Double) As String
        Dim avgSalary As Double = 50000 ' 평균 연봉을 50,000으로 설정 (임의 값)
        If salary > avgSalary * 1.5 Then
            Return "High Income"
        ElseIf salary > avgSalary * 0.75 Then
            Return "Middle Income"
        Else
            Return "Low Income"
        End If
    End Function

    ' 직업을 입력받아 행복도를 추론하는 함수 (임의의 기준 사용)
    Public Function PredictHappinessByJob(job As String) As Double
        Select Case job.ToLower()
            Case "doctor", "engineer", "teacher"
                Return 80 ' 직업에 따른 행복도 (0 ~ 100)
            Case "artist", "musician"
                Return 70
            Case "student"
                Return 60
            Case Else
                Return 50 ' 기타 직업일 경우 기본값
        End Select
    End Function

    ' 나이와 직업을 받아 행복도를 계산하는 함수
    Public Function CalculateHappiness(age As Integer, job As String) As Double
        Dim baseHappiness As Double = PredictHappinessByJob(job)
        Dim ageFactor As Double = (MaxLifeExpectancy - age) / MaxLifeExpectancy * 100
        ' 나이가 많아질수록 행복도는 감소 (단순한 임의 알고리즘)
        Return Math.Max(0, baseHappiness * ageFactor / 100)
    End Function

    ' 전체적인 종합 데이터를 출력하는 함수
    Public Sub DisplayLifeSummary(name As String, age As Integer, salary As Double, job As String)
        Console.WriteLine("Life Summary for " & name & ":")
        Console.WriteLine("------------------------------------------------")

        ' 남은 기대 수명 계산
        Dim remainingYears As Integer = CalculateRemainingLifeExpectancy(age)
        Console.WriteLine("Remaining Life Expectancy: " & remainingYears & " years")

        ' 연봉 분류 계산
        Dim incomeLevel As String = PredictIncomeLevel(salary)
        Console.WriteLine("Income Level: " & incomeLevel)

        ' 행복도 계산
        Dim happiness As Double = CalculateHappiness(age, job)
        Console.WriteLine("Predicted Happiness Level: " & happiness & " out of 100")

        Console.WriteLine("------------------------------------------------")
    End Sub
End Class
