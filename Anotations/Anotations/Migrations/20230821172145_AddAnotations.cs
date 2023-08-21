using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Anotations.Migrations
{
    /// <inheritdoc />
    public partial class AddAnotations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO anotation(Name, Content) " +
                "VALUES('Lorem ipsum teste 1','Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Dictum at tempor commodo ullamcorper a lacus vestibulum. Nisi porta lorem mollis aliquam ut porttitor leo a diam. In dictum non consectetur a erat nam at lectus. Pretium viverra suspendisse potenti nullam ac tortor vitae purus. Pulvinar elementum integer enim neque volutpat ac. Sed vulputate odio ut enim blandit volutpat maecenas volutpat blandit. In nibh mauris cursus mattis. Venenatis lectus magna fringilla urna porttitor rhoncus dolor purus. Donec enim diam vulputate ut.')");

            migrationBuilder.Sql("INSERT INTO anotation(Name, Content) " +
                "VALUES('Lorem ipsum teste 2','Elit eget gravida cum sociis. Ac turpis egestas integer eget aliquet nibh praesent. Bibendum at varius vel pharetra vel turpis nunc eget. Consequat interdum varius sit amet mattis vulputate enim. Urna et pharetra pharetra massa massa ultricies mi quis hendrerit.')");

            migrationBuilder.Sql("INSERT INTO anotation(Name, Content) " +
                "VALUES('Lorem ipsum teste 3','In fermentum et sollicitudin ac orci phasellus egestas. Semper eget duis at tellus at urna. Non consectetur a erat nam at lectus. At urna condimentum mattis pellentesque id nibh tortor id aliquet. Sagittis eu volutpat odio facilisis. Adipiscing elit pellentesque habitant morbi tristique. Est sit amet facilisis magna etiam. Volutpat maecenas volutpat blandit aliquam etiam erat velit scelerisque.')");

            migrationBuilder.Sql("INSERT INTO anotation(Name, Content) " +
                "VALUES('Lorem ipsum teste 4','Amet porttitor eget dolor morbi. Egestas purus viverra accumsan in nisl nisi scelerisque eu. Pharetra pharetra massa massa ultricies mi. Malesuada proin libero nunc consequat interdum. Condimentum mattis pellentesque id nibh tortor id aliquet lectus proin. Faucibus vitae aliquet nec ullamcorper sit amet risus nullam eget. Sit amet nisl suscipit adipiscing bibendum.')");

            migrationBuilder.Sql("INSERT INTO anotation(Name, Content) " +
                "VALUES('Lorem ipsum teste 5','Nunc mattis enim ut tellus elementum sagittis vitae et leo. Volutpat consequat mauris nunc congue nisi vitae suscipit. Aliquet sagittis id consectetur purus ut faucibus pulvinar elementum. Libero justo laoreet sit amet cursus sit amet dictum sit. Imperdiet massa tincidunt nunc pulvinar sapien et. Ullamcorper morbi tincidunt ornare massa eget egestas purus viverra accumsan.')");

            migrationBuilder.Sql("INSERT INTO anotation(Name, Content) " +
                "VALUES('Lorem ipsum teste 6','Volutpat consequat mauris nunc congue nisi vitae suscipit tellus. Quis varius quam quisque id diam vel. Neque vitae tempus quam pellentesque nec nam aliquam. Feugiat nibh sed pulvinar proin. Eu augue ut lectus arcu bibendum at varius. Eu non diam phasellus vestibulum lorem sed risus. Quis lectus nulla at volutpat diam ut. Phasellus vestibulum lorem sed risus.')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Anotation");

        }
    }
}
