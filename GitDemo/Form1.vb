Imports System
Imports System.Reflection.Emit
'######################################################################################
'## 내  용 : 깃허브 데모 예제                                                         ##
'## 작성일 : 2024-10-18                                                               ##
'## 작성자 : 박정우(chanios127)                                                       ##
'## 수정일:  2024-10-18                                                               ##
'## 수정자 : 박정우                                                                   ##
'######################################################################################
Public Class Form1
    ' 폼에 추가할 컨트롤들 선언
    Private nameLabel As New Label()
    Private ageLabel As New Label()
    Private nameTextBox As New TextBox()
    Private ageTextBox As New TextBox()
    Private submitButton As New Button()
    Private resultLabel As New Label()

    ' 폼 초기화 메서드
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Name Label 설정
        nameLabel.Text = "Enter your name:"
        nameLabel.Location = New Point(10, 10)
        Me.Controls.Add(nameLabel)

        ' Name TextBox 설정
        nameTextBox.Location = New Point(150, 10)
        nameTextBox.Size = New Size(200, 30)
        Me.Controls.Add(nameTextBox)

        ' Age Label 설정
        ageLabel.Text = "Enter your age:"
        ageLabel.Location = New Point(10, 50)
        Me.Controls.Add(ageLabel)

        ' Age TextBox 설정
        ageTextBox.Location = New Point(150, 50)
        ageTextBox.Size = New Size(50, 30)
        Me.Controls.Add(ageTextBox)

        ' Submit Button 설정
        submitButton.Text = "Submit"
        submitButton.Location = New Point(10, 90)
        AddHandler submitButton.Click, AddressOf Me.SubmitButton_Click
        Me.Controls.Add(submitButton)

        ' 결과를 보여줄 Label 설정
        resultLabel.Location = New Point(10, 130)
        resultLabel.Size = New Size(300, 50)
        Me.Controls.Add(resultLabel)
    End Sub

    ' Submit Button 클릭 이벤트 핸들러
    Private Sub SubmitButton_Click(sender As Object, e As EventArgs)
        ' 이름과 나이를 입력받아 유효성 검사 및 결과 표시
        Dim userName As String = nameTextBox.Text
        Dim userAge As Integer

        ' 입력 유효성 검사
        If String.IsNullOrWhiteSpace(userName) Then
            MessageBox.Show("Name cannot be empty!")
            Return
        End If

        ' 나이 입력이 정수인지 확인
        If Not Integer.TryParse(ageTextBox.Text, userAge) Then
            MessageBox.Show("Please enter a valid age!")
            Return
        End If

        ' 나이에 따른 메시지 출력
        If userAge < 18 Then
            resultLabel.Text = "Hello " & userName & ", you are a minor."
        ElseIf userAge >= 18 And userAge <= 65 Then
            resultLabel.Text = "Hello " & userName & ", you are an adult."
        Else
            resultLabel.Text = "Hello " & userName & ", you are a senior."
        End If
    End Sub

    Public Sub Test()
        Dim S As String = "커밋 테스트용 서브루틴 추가"
        '커밋 테스트 확인용 주석
        For i As Integer = 0 To 5
            MsgBox("커밋 테스트용 서브루틴")
        Next
    End Sub

    Public Sub ConflicTest()
        Dim S As String = "커밋 과정중 충돌상황 가정 "
        '커밋 테스트 확인용 주석
        For i As Integer = 0 To 5
            MsgBox("커밋 테스트용 서브루틴")
        Next
    End Sub
End Class
