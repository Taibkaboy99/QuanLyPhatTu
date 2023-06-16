using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyPhatTu.Migrations
{
    /// <inheritdoc />
    public partial class data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Chuas",
                columns: table => new
                {
                    ChuaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenChua = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayThanhLap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TruTri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CapNhat = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chuas", x => x.ChuaId);
                });

            migrationBuilder.CreateTable(
                name: "KieuThanhViens",
                columns: table => new
                {
                    KieuThanhVienId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenKieu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KieuThanhViens", x => x.KieuThanhVienId);
                });

            migrationBuilder.CreateTable(
                name: "PhatTus",
                columns: table => new
                {
                    PhatTuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ho = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenDem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhapDanh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnhChup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayXuatGia = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DaHoanTuc = table.Column<bool>(type: "bit", nullable: false),
                    NgayHoanTuc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KieuThanhVienId = table.Column<int>(type: "int", nullable: true),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChuaId = table.Column<int>(type: "int", nullable: true),
                    ChuasChuaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhatTus", x => x.PhatTuId);
                    table.ForeignKey(
                        name: "FK_PhatTus_Chuas_ChuasChuaId",
                        column: x => x.ChuasChuaId,
                        principalTable: "Chuas",
                        principalColumn: "ChuaId");
                    table.ForeignKey(
                        name: "FK_PhatTus_KieuThanhViens_KieuThanhVienId",
                        column: x => x.KieuThanhVienId,
                        principalTable: "KieuThanhViens",
                        principalColumn: "KieuThanhVienId");
                });

            migrationBuilder.CreateTable(
                name: "DaoTrangs",
                columns: table => new
                {
                    DaoTrangId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoiToChuc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoThanhVienThamGia = table.Column<int>(type: "int", nullable: false),
                    NguoiChuTriId = table.Column<int>(type: "int", nullable: false),
                    ThoiGianToChuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NoiDung = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DaKetThuc = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DaoTrangs", x => x.DaoTrangId);
                    table.ForeignKey(
                        name: "FK_DaoTrangs_PhatTus_NguoiChuTriId",
                        column: x => x.NguoiChuTriId,
                        principalTable: "PhatTus",
                        principalColumn: "PhatTuId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DonDangKys",
                columns: table => new
                {
                    DonDangKyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhatTuId = table.Column<int>(type: "int", nullable: false),
                    TrangThaiDon = table.Column<int>(type: "int", nullable: false),
                    NgayGuiDon = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgaySuLy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NguoiSuLyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonDangKys", x => x.DonDangKyId);
                    table.ForeignKey(
                        name: "FK_DonDangKys_PhatTus_PhatTuId",
                        column: x => x.PhatTuId,
                        principalTable: "PhatTus",
                        principalColumn: "PhatTuId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhatTuDaoTrangs",
                columns: table => new
                {
                    PhatTuDaoTrangId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhatTuId = table.Column<int>(type: "int", nullable: true),
                    DaoTrangId = table.Column<int>(type: "int", nullable: false),
                    DaThamGia = table.Column<bool>(type: "bit", nullable: false),
                    LyDoKhongThamGia = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhatTuDaoTrangs", x => x.PhatTuDaoTrangId);
                    table.ForeignKey(
                        name: "FK_PhatTuDaoTrangs_DaoTrangs_DaoTrangId",
                        column: x => x.DaoTrangId,
                        principalTable: "DaoTrangs",
                        principalColumn: "DaoTrangId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhatTuDaoTrangs_PhatTus_PhatTuId",
                        column: x => x.PhatTuId,
                        principalTable: "PhatTus",
                        principalColumn: "PhatTuId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_DaoTrangs_NguoiChuTriId",
                table: "DaoTrangs",
                column: "NguoiChuTriId");

            migrationBuilder.CreateIndex(
                name: "IX_DonDangKys_PhatTuId",
                table: "DonDangKys",
                column: "PhatTuId");

            migrationBuilder.CreateIndex(
                name: "IX_PhatTuDaoTrangs_DaoTrangId",
                table: "PhatTuDaoTrangs",
                column: "DaoTrangId");

            migrationBuilder.CreateIndex(
                name: "IX_PhatTuDaoTrangs_PhatTuId",
                table: "PhatTuDaoTrangs",
                column: "PhatTuId");

            migrationBuilder.CreateIndex(
                name: "IX_PhatTus_ChuasChuaId",
                table: "PhatTus",
                column: "ChuasChuaId");

            migrationBuilder.CreateIndex(
                name: "IX_PhatTus_KieuThanhVienId",
                table: "PhatTus",
                column: "KieuThanhVienId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DonDangKys");

            migrationBuilder.DropTable(
                name: "PhatTuDaoTrangs");

            migrationBuilder.DropTable(
                name: "DaoTrangs");

            migrationBuilder.DropTable(
                name: "PhatTus");

            migrationBuilder.DropTable(
                name: "Chuas");

            migrationBuilder.DropTable(
                name: "KieuThanhViens");
        }
    }
}
