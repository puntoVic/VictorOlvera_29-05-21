// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MiniProyecto.Components.BlazorPages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Proyectos\MiniProyecto\MiniProyecto\MiniProyecto\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Proyectos\MiniProyecto\MiniProyecto\MiniProyecto\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Proyectos\MiniProyecto\MiniProyecto\MiniProyecto\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Proyectos\MiniProyecto\MiniProyecto\MiniProyecto\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Proyectos\MiniProyecto\MiniProyecto\MiniProyecto\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Proyectos\MiniProyecto\MiniProyecto\MiniProyecto\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Proyectos\MiniProyecto\MiniProyecto\MiniProyecto\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Proyectos\MiniProyecto\MiniProyecto\MiniProyecto\_Imports.razor"
using MiniProyecto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Proyectos\MiniProyecto\MiniProyecto\MiniProyecto\_Imports.razor"
using MiniProyecto.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Proyectos\MiniProyecto\MiniProyecto\MiniProyecto\_Imports.razor"
using MiniProyecto.Components.BlazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Proyectos\MiniProyecto\MiniProyecto\MiniProyecto\Components\BlazorPages\AlbumComponent.razor"
using Entities;

#line default
#line hidden
#nullable disable
    public partial class AlbumComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 70 "D:\Proyectos\MiniProyecto\MiniProyecto\MiniProyecto\Components\BlazorPages\AlbumComponent.razor"
       
    [Parameter]
    public int IdAlbum { get; set; }


    private string commentsText = String.Empty;
    private List<Album> albums;
    private Album album;
    private List<Photo> photos;
    private List<Comment> comments;
    protected override async Task OnInitializedAsync()
    {
        albums = await Http.GetFromJsonAsync<List<Album>>("https://jsonplaceholder.typicode.com/albums");
        photos = await Http.GetFromJsonAsync<List<Photo>>("https://jsonplaceholder.typicode.com/photos");

        album = albums.Where(x => x.id == IdAlbum).First();
        photos = photos.Where(x => x.albumId == IdAlbum).ToList();
    }
    async Task LoadComments(int id)
    {
        commentsText = String.Empty;
        comments = await Http.GetFromJsonAsync<List<Comment>>("https://jsonplaceholder.typicode.com/comments");
        comments = comments.Where(x => x.postId == id).ToList();
        foreach (var comment in comments)
        {
            commentsText = String.Concat(commentsText, comment.body.ToString(), "\n\n\n");

        }

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
