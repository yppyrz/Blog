﻿// <auto-generated />
using System;
using Blog.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Blog.Migrations
{
    [DbContext(typeof(BlogDbContext))]
    [Migration("20211222154639_First")]
    partial class First
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Blog.Entities.Category", b =>
                {
                    b.Property<string>("CategoryID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Blog.Entities.Comment", b =>
                {
                    b.Property<string>("CommentID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CommentContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CommentPostPostID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CommentPublishDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CommentID");

                    b.HasIndex("CommentPostPostID");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Blog.Entities.Post", b =>
                {
                    b.Property<string>("PostID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PostAuthorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostCategoryCategoryID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PostContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PostPublishDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PostTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PostID");

                    b.HasIndex("PostCategoryCategoryID");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("Blog.Entities.Tag", b =>
                {
                    b.Property<string>("TagID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TagName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TagID");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("PostTag", b =>
                {
                    b.Property<string>("PostTagsTagID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TagPostsPostID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("PostTagsTagID", "TagPostsPostID");

                    b.HasIndex("TagPostsPostID");

                    b.ToTable("PostTag");
                });

            modelBuilder.Entity("Blog.Entities.Comment", b =>
                {
                    b.HasOne("Blog.Entities.Post", "CommentPost")
                        .WithMany("PostComments")
                        .HasForeignKey("CommentPostPostID");

                    b.Navigation("CommentPost");
                });

            modelBuilder.Entity("Blog.Entities.Post", b =>
                {
                    b.HasOne("Blog.Entities.Category", "PostCategory")
                        .WithMany("CategoryPosts")
                        .HasForeignKey("PostCategoryCategoryID");

                    b.Navigation("PostCategory");
                });

            modelBuilder.Entity("PostTag", b =>
                {
                    b.HasOne("Blog.Entities.Tag", null)
                        .WithMany()
                        .HasForeignKey("PostTagsTagID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Blog.Entities.Post", null)
                        .WithMany()
                        .HasForeignKey("TagPostsPostID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Blog.Entities.Category", b =>
                {
                    b.Navigation("CategoryPosts");
                });

            modelBuilder.Entity("Blog.Entities.Post", b =>
                {
                    b.Navigation("PostComments");
                });
#pragma warning restore 612, 618
        }
    }
}
