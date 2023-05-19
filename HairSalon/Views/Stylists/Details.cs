@{
  Layout = "_Layout";
}

@model HairSalon.Models.Stylist
@using HairSalon.Models

<h2>Stylist Details</h2>
<hr />
<h3>@Html.DisplayNameFor(model => model.StylistName): @Html.DisplayFor(model => model.StylistName)<h3>

@if (@Model.Clients.Count == 0)
{
  <h3>No clients have been added to this stylist yet!</h3>
} 
else
{
  <h3>Clients:</h3>
  <ul>
    @foreach (Client client in Model.)
    {
      <li>@Html.ActionLink($"{clent.ClientName}", "Details", "Clients", new { id = client.ClientId })</li>
    }
  </ul>
}

<p>@Html.ActionLink("Edit Stylist", "Edit", new { id = Model.StylistId })</p>
<p>@Html.ActionLink("Delete Stylist", "Delete", new { id = Model.StylistId })</p>
<p>@Html.ActionLink("Back to list", "Index")</p>