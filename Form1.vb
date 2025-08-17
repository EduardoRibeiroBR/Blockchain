Imports System.Security.Cryptography
Imports System.Text
Imports System.Threading
Imports Newtonsoft.Json

Public Class Form1

#Region "var"
    Public blockchainList As New List(Of Block)
    Public wait As Boolean = True
    Public transactionsList As New List(Of Transaction)
    Public maxBlockSize As Integer = 2
    Public C1 As New Token
    Public C2 As New Token
#End Region

#Region "Objects"
    Class Transaction
        Public id As String
        Public sender As User
        Public receiver As User
        Public token As Token
        Public valid As Boolean
        Public processed As Boolean
    End Class

    Class Token
        Public id As String
        Public owner As User
    End Class

    Class User
        Public id As String
    End Class

    Class Block
        Public id As String
        Public hashHeader As String
        Public transactions As New List(Of Transaction)
        Public jsonBody As String
    End Class

    Class BlockChain
        Public blockList As List(Of Block)
    End Class
#End Region

#Region "Events"

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Start()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        wait = False
    End Sub

    Private Sub lvBlockchain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvBlockchain.SelectedIndexChanged
        Try
            Dim selectedBlockId As String = lvBlockchain.SelectedItems(0).Text
            lvSelectedBlock.Items.Clear()

            Dim selectedBlock As Block = blockchainList.Find(Function(b) b.id = selectedBlockId)

            For Each transaction As Transaction In selectedBlock.transactions

                Dim lvItem As New ListViewItem(selectedBlockId)
                lvItem.SubItems.Add(transaction.id)
                lvItem.SubItems.Add(transaction.sender.id)
                lvItem.SubItems.Add(transaction.receiver.id)
                lvItem.SubItems.Add(transaction.token.id)

                lvSelectedBlock.Items.Add(lvItem)
            Next

            header.Text = selectedBlock.hashHeader
            body.Text = selectedBlock.jsonBody

        Catch ex As Exception

        End Try

    End Sub

#End Region

    Public Sub Start()
        transactionsList = CreateTransactionsList()

        UpdateForm(Nothing)

        Dim thread As New Thread(Sub() ProcessTransactions(transactionsList))
        thread.Start()
    End Sub

    Public Sub UpdateForm(currentTransaction As Transaction)

        Application.OpenForms.OfType(Of Form1).First.Invoke(New MethodInvoker(Sub()
                                                                                  'Atualização lista Transações
                                                                                  lvTransactions.Items.Clear()

                                                                                  For Each transaction As Transaction In transactionsList

                                                                                      Dim lvitem As New ListViewItem(transaction.id)
                                                                                      lvitem.SubItems.Add(transaction.sender.id)
                                                                                      lvitem.SubItems.Add(transaction.receiver.id)
                                                                                      lvitem.SubItems.Add(transaction.token.id)

                                                                                      lvTransactions.Items.Add(lvitem)
                                                                                  Next

                                                                                  'Atualização blockchain
                                                                                  lvBlockchain.Items.Clear()

                                                                                  For Each block As Block In blockchainList

                                                                                      Dim lvitem As New ListViewItem(block.id)
                                                                                      lvitem.SubItems.Add(block.hashHeader)
                                                                                      lvitem.SubItems.Add(JsonConvert.SerializeObject(block))

                                                                                      lvBlockchain.Items.Add(lvitem)
                                                                                  Next

                                                                                  C1Owner.Text = C1.owner.id
                                                                                  C2Owner.Text = C2.owner.id

                                                                                  If currentTransaction IsNot Nothing Then
                                                                                      ctId.Text = currentTransaction.id
                                                                                      ctToken.Text = currentTransaction.token.id
                                                                                      ctSender.Text = currentTransaction.sender.id
                                                                                      ctReceiver.Text = currentTransaction.receiver.id

                                                                                      For Each item As ListViewItem In lvTransactions.Items

                                                                                          If item.Text = currentTransaction.id Then
                                                                                              item.BackColor = Color.Yellow
                                                                                          End If

                                                                                          For Each transaction In transactionsList
                                                                                              If transaction.id = item.Text And transaction.processed Then
                                                                                                  If transaction.valid Then
                                                                                                      item.BackColor = Color.Green
                                                                                                  Else
                                                                                                      item.BackColor = Color.Red
                                                                                                  End If
                                                                                              End If
                                                                                          Next
                                                                                      Next
                                                                                  End If

                                                                                  If lvBlockchain.Items.Count > 0 Then
                                                                                      lvBlockchain.SelectedItems.Clear()
                                                                                      lvBlockchain.Items.Item(lvBlockchain.Items.Count - 1).Selected = True
                                                                                  End If

                                                                                  Application.DoEvents()
                                                                              End Sub))
    End Sub

    Public Function CreateTransactionsList() As List(Of Transaction)
        Dim A As New User
        A.id = "A"

        Dim B As New User
        B.id = "B"

        Dim C As New User
        C.id = "C"

        Dim D As New User
        D.id = "D"

        C1 = New Token With {
            .owner = A,
            .id = "C1"
        }

        C2 = New Token With {
            .owner = B,
            .id = "C2"
        }

        Dim T1 As New Transaction With {
            .id = "T1",
            .sender = A,
            .receiver = B,
            .token = C1
        }

        Dim T2 As New Transaction With {
            .id = "T2",
            .sender = B,
            .receiver = C,
            .token = C2
        }

        Dim T3 As New Transaction With {
            .id = "T3",
            .sender = A,
            .receiver = D,
            .token = C1
        }

        Dim T4 As New Transaction With {
            .id = "T4",
            .sender = B,
            .receiver = D,
            .token = C1
        }

        Dim T5 As New Transaction With {
            .id = "T5",
            .sender = C,
            .receiver = B,
            .token = C2
        }

        Dim T6 As New Transaction With {
            .id = "T6",
            .sender = D,
            .receiver = A,
            .token = C1
        }

        transactionsList = New List(Of Transaction)
        transactionsList.Add(T1)
        transactionsList.Add(T2)
        transactionsList.Add(T3)
        transactionsList.Add(T4)
        transactionsList.Add(T5)
        transactionsList.Add(T6)

        Return transactionsList

    End Function

    Public Sub WaitNextStep(currentTransaction As Transaction)

        UpdateForm(currentTransaction)

        wait = True

        While wait
            Thread.Sleep(1000)
        End While
    End Sub

    Public Sub ProcessTransactions(list As List(Of Transaction))
        Dim blockSize As Integer = 0
        blockchainList = New List(Of Block)
        WaitNextStep(Nothing)

        For Each transaction As Transaction In list
            WaitNextStep(transaction)

            'Check if token belongs to sender
            If transaction.token.owner.Equals(transaction.sender) Then

                transaction.valid = True

                If blockchainList.Count = 0 Then

                    Dim newBlock As New Block
                    newBlock.hashHeader = "00000"
                    newBlock.transactions.Add(transaction)
                    newBlock.id = "Bloco 1"
                    newBlock.jsonBody = JsonConvert.SerializeObject(newBlock)
                    blockchainList.Add(newBlock)

                ElseIf blockchainList.Count > 0 Then

                    Dim lastBlock = blockchainList.ElementAt(blockchainList.Count - 1)

                    If lastBlock.transactions.Count < maxBlockSize Then

                        lastBlock.transactions.Add(transaction)
                    Else
                        Dim newBlock = GenerateNewBlock(lastBlock)
                        newBlock.transactions.Add(transaction)
                        blockchainList.Add(newBlock)
                    End If
                End If

                transaction.token.owner = transaction.receiver
            Else 'Invalid transaction
                transaction.valid = False
            End If
            transaction.processed = True
        Next
    End Sub

    Public Function GenerateNewBlock(lastBlock As Block) As Block
        Dim newBlock As New Block

        lastBlock.jsonBody = JsonConvert.SerializeObject(lastBlock)
        newBlock.hashHeader = ComputeMD5(lastBlock.jsonBody)
        newBlock.id = $"Bloco {blockchainList.Count + 1}"

        Return newBlock
    End Function

    Public Function ComputeMD5(rawData As String) As String
        Using md5 As MD5 = MD5.Create()
            Dim bytes As Byte() = md5.ComputeHash(Encoding.UTF8.GetBytes(rawData))
            Dim builder As New StringBuilder()
            For Each b In bytes
                builder.Append(b.ToString("x2"))
            Next
            Return builder.ToString()
        End Using
    End Function

End Class
