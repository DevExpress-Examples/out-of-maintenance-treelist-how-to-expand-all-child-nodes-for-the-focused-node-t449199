@Imports DevExpress.Web.ASPxTreeList

@Html.DevExpress().TreeList(
    Sub(settings)
        settings.Name = "treeList"
        settings.CallbackRouteValues = New With {Key .Controller = "Home", Key .Action = "TreeListPartial"}
        settings.Width = Unit.Pixel(800)

        settings.AutoGenerateColumns = False
        settings.KeyFieldName = "ID"
        settings.ParentFieldName = "ParentID"
        settings.SettingsBehavior.AllowFocusedNode = True
        settings.ClientSideEvents.ContextMenu = "OnContextMenu"

        settings.Columns.Add("Name", "Department")
        settings.Columns.Add(Sub(column)
                                    column.FieldName = "Budget"
                                    column.PropertiesEdit.DisplayFormatString = "{0:C}"
                            End Sub)
        settings.Columns.Add("Location")
        settings.Columns.Add("Phone1", "Phone")

        settings.BeforeGetCallbackResult = Sub(sender, e)
                If (ViewData("Expand") Is Nothing) Then Return
                Dim treeList As ASPxTreeList = TryCast(sender, ASPxTreeList)
                Dim currentNodeLevel = treeList.FocusedNode.Level
                Dim Iterator As TreeListNodeIterator = New TreeListNodeIterator(treeList.FocusedNode)
                While (Iterator.Current IsNot Nothing)
                    Dim node As TreeListNode = Iterator.Current
                    If (node.Level >= currentNodeLevel) Then node.Expanded = True
                        Iterator.GetNext()
                End While
		End Sub
End Sub).Bind(Model).GetHtml()

