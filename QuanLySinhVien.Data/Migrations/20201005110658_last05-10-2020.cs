using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLySinhVien.Data.Migrations
{
    public partial class last05102020 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7e2de1ee-b97b-4698-abe4-c22a0332b2c9"),
                column: "ConcurrencyStamp",
                value: "fe8854fe-0960-4a57-a38c-c50bdbf783d8");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ddcfd40f-0c20-4bbd-afbf-5936032ddde5"),
                column: "ConcurrencyStamp",
                value: "c893ce26-4686-437b-a7e9-24021439fc52");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("8dd4e4e7-cbb1-4db8-8cd8-3024401afc74"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "12dae6fd-1736-4e03-8bb2-dd3278050938", "AQAAAAEAACcQAAAAEJG97tksvQK+UYkJu6xwk7O+o/C9vCQVSU42f5kTQUUBzK54iCpyO6MAbrXLCJvL3w==" });

            migrationBuilder.UpdateData(
                table: "GiangViens",
                keyColumn: "ID",
                keyValue: "GV001",
                column: "IsActive",
                value: 1);

            migrationBuilder.UpdateData(
                table: "GiangViens",
                keyColumn: "ID",
                keyValue: "GV002",
                column: "IsActive",
                value: 1);

            migrationBuilder.UpdateData(
                table: "GiangViens",
                keyColumn: "ID",
                keyValue: "GV003",
                column: "IsActive",
                value: 1);

            migrationBuilder.UpdateData(
                table: "LopHocPhans",
                keyColumn: "ID",
                keyValue: "161INT00101",
                columns: new[] { "ID_GiangVien", "IsActive" },
                values: new object[] { "GV003", 1 });

            migrationBuilder.UpdateData(
                table: "LopHocPhans",
                keyColumn: "ID",
                keyValue: "161INT00102",
                columns: new[] { "ID_GiangVien", "IsActive" },
                values: new object[] { "GV001", 1 });

            migrationBuilder.UpdateData(
                table: "LopHocPhans",
                keyColumn: "ID",
                keyValue: "161INT00201",
                columns: new[] { "ID_GiangVien", "IsActive" },
                values: new object[] { "GV003", 1 });

            migrationBuilder.UpdateData(
                table: "LopHocPhans",
                keyColumn: "ID",
                keyValue: "161INT00301",
                columns: new[] { "ID_GiangVien", "IsActive" },
                values: new object[] { "GV001", 1 });

            migrationBuilder.UpdateData(
                table: "LopHocPhans",
                keyColumn: "ID",
                keyValue: "161INT00401",
                columns: new[] { "ID_GiangVien", "IsActive" },
                values: new object[] { "GV001", 1 });

            migrationBuilder.UpdateData(
                table: "SinhViens",
                keyColumn: "ID",
                keyValue: "161A010001",
                column: "IsActive",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SinhViens",
                keyColumn: "ID",
                keyValue: "161A010002",
                column: "IsActive",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SinhViens",
                keyColumn: "ID",
                keyValue: "161A010003",
                column: "IsActive",
                value: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7e2de1ee-b97b-4698-abe4-c22a0332b2c9"),
                column: "ConcurrencyStamp",
                value: "06ba06a2-3cf0-4ebf-96a6-1f8d6fe74fe5");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("ddcfd40f-0c20-4bbd-afbf-5936032ddde5"),
                column: "ConcurrencyStamp",
                value: "8044b1f1-adb7-44ec-9d5f-2774406d364f");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("8dd4e4e7-cbb1-4db8-8cd8-3024401afc74"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d1b4f6dc-602f-49aa-9189-26f87824fc2a", "AQAAAAEAACcQAAAAED6x+B88vpvP58msB4HdKRrICYgQ54xA7uGb5SO27STvGESig0wr86+viXkTTCVETA==" });

            migrationBuilder.UpdateData(
                table: "GiangViens",
                keyColumn: "ID",
                keyValue: "GV001",
                column: "IsActive",
                value: 1);

            migrationBuilder.UpdateData(
                table: "GiangViens",
                keyColumn: "ID",
                keyValue: "GV002",
                column: "IsActive",
                value: 1);

            migrationBuilder.UpdateData(
                table: "GiangViens",
                keyColumn: "ID",
                keyValue: "GV003",
                column: "IsActive",
                value: 1);

            migrationBuilder.UpdateData(
                table: "LopHocPhans",
                keyColumn: "ID",
                keyValue: "161INT00101",
                columns: new[] { "ID_GiangVien", "IsActive" },
                values: new object[] { null, 1 });

            migrationBuilder.UpdateData(
                table: "LopHocPhans",
                keyColumn: "ID",
                keyValue: "161INT00102",
                columns: new[] { "ID_GiangVien", "IsActive" },
                values: new object[] { null, 1 });

            migrationBuilder.UpdateData(
                table: "LopHocPhans",
                keyColumn: "ID",
                keyValue: "161INT00201",
                columns: new[] { "ID_GiangVien", "IsActive" },
                values: new object[] { null, 1 });

            migrationBuilder.UpdateData(
                table: "LopHocPhans",
                keyColumn: "ID",
                keyValue: "161INT00301",
                columns: new[] { "ID_GiangVien", "IsActive" },
                values: new object[] { null, 1 });

            migrationBuilder.UpdateData(
                table: "LopHocPhans",
                keyColumn: "ID",
                keyValue: "161INT00401",
                columns: new[] { "ID_GiangVien", "IsActive" },
                values: new object[] { null, 1 });

            migrationBuilder.UpdateData(
                table: "SinhViens",
                keyColumn: "ID",
                keyValue: "161A010001",
                column: "IsActive",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SinhViens",
                keyColumn: "ID",
                keyValue: "161A010002",
                column: "IsActive",
                value: 1);

            migrationBuilder.UpdateData(
                table: "SinhViens",
                keyColumn: "ID",
                keyValue: "161A010003",
                column: "IsActive",
                value: 1);
        }
    }
}
