Public NotInheritable Class DepartmentsProvider

    Private Sub New()
    End Sub

    Public Shared Function GetDepartments() As List(Of Department)
        Return New List(Of Department) From
            {
               New Department(1, 0, "Corporate Headquarters", 1000000, "Monterey", "(408) 555-1234"),
               New Department(2, 1, "Sales and Marketing", 22000, "San Francisco", "(415) 555-1234"),
               New Department(3, 2, "Field Office: Canada", 500000, "Toronto", "(416) 677-1000", "(416) 555-1234"),
               New Department(4, 2, "Field Office: East Coast", 500000, "Boston", "(617) 555-4234", "(415) 555-1234"),
               New Department(5, 2, "Pacific Rim Headquarters", 600000, "Kuaui", "(808) 555-1234"),
               New Department(6, 5, "Field Office: Singapore", 300000, "Singapore", "(606) 555-5486", "(606) 555-5786"),
               New Department(7, 5, "Field Office: Japan", 500000, "Tokyo", "(707) 555-1526", "(707) 555-5432"),
               New Department(8, 2, "Marketing", 1500000, "San Francisco", "(415) 555-1234"),
               New Department(9, 1, "Finance", 40000, "Monterey", "(408) 555-1234"),
               New Department(10, 1, "Engineering", 1100000, "Monterey", "(408) 555-1234"),
               New Department(11, 10, "Consumer Electronics Div.", 1150000, "Burlington, VT", "(802) 555-1234"),
               New Department(12, 11, "Software Development", 40000, "Monterey", "(408) 555-1234"),
               New Department(13, 10, "Software Products Div.", 1200000, "Monterey", "(408) 555-1234"),
               New Department(14, 13, "Quality Assurance", 48000, "Monterey", "(408) 555-1234", "(408) 555-1234"),
               New Department(15, 13, "Customer Support", 38000, "Monterey", "(408) 555-1234"),
               New Department(16, 13, "Research and Development", 460000, "Burlington, VT", "(802) 555-1234"),
               New Department(17, 13, "Customer Services", 850000, "Burlington, VT", "(802) 555-1234")
            }
    End Function
End Class

Public Class Department
    Private id_Renamed As Integer
    Private name_Renamed As String
    Private location_Renamed As String
    Private budget_Renamed As Integer
    Private parentID_Renamed As Integer
    Private phone1_Renamed As String
    Private phone2_Renamed As String

    Public Sub New(ByVal id As Integer, ByVal parentID As Integer, ByVal name As String, ByVal budget As Integer, ByVal location As String, ByVal phone1 As String, Optional ByVal phone2 As String = Nothing)
        Me.id_Renamed = id
        Me.parentID_Renamed = parentID
        Me.name_Renamed = name
        Me.budget_Renamed = budget
        Me.location_Renamed = location
        Me.phone1_Renamed = phone1
        Me.phone2_Renamed = If(String.IsNullOrEmpty(phone2), phone1, phone2)
    End Sub

    Public ReadOnly Property ID() As Integer
        Get
            Return id_Renamed
        End Get
    End Property
    Public ReadOnly Property ParentID() As Integer
        Get
            Return parentID_Renamed
        End Get
    End Property
    Public ReadOnly Property Name() As String
        Get
            Return name_Renamed
        End Get
    End Property
    Public ReadOnly Property Budget() As Integer
        Get
            Return budget_Renamed
        End Get
    End Property
    Public ReadOnly Property Location() As String
        Get
            Return location_Renamed
        End Get
    End Property
    Public ReadOnly Property Phone1() As String
        Get
            Return phone1_Renamed
        End Get
    End Property
    Public ReadOnly Property Phone2() As String
        Get
            Return phone2_Renamed
        End Get
    End Property
End Class
