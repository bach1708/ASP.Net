@Code
    ViewData("Title") = "Giới Thiệu Về Trường Đại Học Nguyễn Trãi"
    ViewData("Message")= "Cơ sở vật chất và khuôn viên trường"
End Code
<main aria-labelledby="title">
    <h2 id="title">@ViewData("Title").</h2>
    <h3>@ViewData("Message")</h3>
    <h1> Thầy Hiệu Trưởng Nhà Trường </h1>
    <div class="center">
        <img src="~/Models/3.jpg" alt="Ảnh trường học XYZ" width="1200" height="600" />
    </div>
    <h1> Hình Ảnh Trường </h1>
    <div style=" text-align">
        <img src="~/Models/4.jpg" alt="Ảnh trường học XYZ" width="400" height="200" />
        <img src="~/Models/5.jpg" alt="Ảnh trường học XYZ" width="400" height="200" />
    </div>

</main>
