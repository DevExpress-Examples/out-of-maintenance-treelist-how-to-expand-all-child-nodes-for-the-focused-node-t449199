<script type="text/javascript">
    function OnPopupMenuItemClick(s, t) {
        treeList.PerformCallback({ 'Expand': true });
    }
    function OnContextMenu(s, e) {
        if (e.objectType == "Node") {
            key = e.objectKey;
            var state = s.GetNodeState(e.objectKey);
            if (state != "Child" && state != "NotFound" && e.objectKey == s.GetFocusedNodeKey())
                PopupMenu.ShowAtPos(ASPxClientUtils.GetEventX(e.htmlEvent), ASPxClientUtils.GetEventY(e.htmlEvent));
        }
    }
</script>

@Html.DevExpress().PopupMenu(
	Sub(settings)
        settings.Name = "PopupMenu"
        settings.Items.Add(Sub(item)
            item.Text = "Expand to leaf"
            item.Name = "Expand"
        End Sub)
        settings.ClientSideEvents.ItemClick = "OnPopupMenuItemClick"
End Sub).GetHtml()

@Html.Action("TreeListPartial")

