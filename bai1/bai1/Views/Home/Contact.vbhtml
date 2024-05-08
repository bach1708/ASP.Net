@Code
    ViewData("Title") = "Contact"
End Code

<main aria-labelledby="title">
    <h2 id="title">@ViewData("Title").</h2>
    <h3>@ViewData("Message")</h3>

    <address>
        <img src="~/Models/7.jpg" alt="Ảnh trường học XYZ" width="200" height="200" /><br />
        Tôi là Nông Văn Bách<br />
        Sinh viên K22CNT2<br />
        Liên hệ với tôi qua<br />
        <abbr title="Phone">P:</abbr>
        0387387894
    </address>
    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
    </address>
</main>