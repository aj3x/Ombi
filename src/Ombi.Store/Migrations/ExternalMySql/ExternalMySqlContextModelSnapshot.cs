﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Ombi.Store.Context.MySql;

namespace Ombi.Store.Migrations.ExternalMySql
{
    [DbContext(typeof(ExternalMySqlContext))]
    partial class ExternalMySqlContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Ombi.Store.Entities.CouchPotatoCache", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("TheMovieDbId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CouchPotatoCache");
                });

            modelBuilder.Entity("Ombi.Store.Entities.EmbyContent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("AddedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("EmbyId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ImdbId")
                        .HasColumnType("longtext");

                    b.Property<string>("ProviderId")
                        .HasColumnType("longtext");

                    b.Property<string>("TheMovieDbId")
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .HasColumnType("longtext");

                    b.Property<string>("TvDbId")
                        .HasColumnType("longtext");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("EmbyContent");
                });

            modelBuilder.Entity("Ombi.Store.Entities.EmbyEpisode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("AddedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("EmbyId")
                        .HasColumnType("longtext");

                    b.Property<int>("EpisodeNumber")
                        .HasColumnType("int");

                    b.Property<string>("ImdbId")
                        .HasColumnType("longtext");

                    b.Property<string>("ParentId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderId")
                        .HasColumnType("longtext");

                    b.Property<int>("SeasonNumber")
                        .HasColumnType("int");

                    b.Property<string>("TheMovieDbId")
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .HasColumnType("longtext");

                    b.Property<string>("TvDbId")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("EmbyEpisode");
                });

            modelBuilder.Entity("Ombi.Store.Entities.JellyfinContent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("AddedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ImdbId")
                        .HasColumnType("longtext");

                    b.Property<string>("JellyfinId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderId")
                        .HasColumnType("longtext");

                    b.Property<string>("TheMovieDbId")
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .HasColumnType("longtext");

                    b.Property<string>("TvDbId")
                        .HasColumnType("longtext");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("JellyfinContent");
                });

            modelBuilder.Entity("Ombi.Store.Entities.JellyfinEpisode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("AddedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("EpisodeNumber")
                        .HasColumnType("int");

                    b.Property<string>("ImdbId")
                        .HasColumnType("longtext");

                    b.Property<string>("JellyfinId")
                        .HasColumnType("longtext");

                    b.Property<string>("ParentId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderId")
                        .HasColumnType("longtext");

                    b.Property<int>("SeasonNumber")
                        .HasColumnType("int");

                    b.Property<string>("TheMovieDbId")
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .HasColumnType("longtext");

                    b.Property<string>("TvDbId")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("JellyfinEpisode");
                });

            modelBuilder.Entity("Ombi.Store.Entities.LidarrAlbumCache", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("AddedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<string>("ForeignAlbumId")
                        .HasColumnType("longtext");

                    b.Property<bool>("Monitored")
                        .HasColumnType("tinyint(1)");

                    b.Property<decimal>("PercentOfTracks")
                        .HasColumnType("decimal(65,30)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Title")
                        .HasColumnType("longtext");

                    b.Property<int>("TrackCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("LidarrAlbumCache");
                });

            modelBuilder.Entity("Ombi.Store.Entities.LidarrArtistCache", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<string>("ArtistName")
                        .HasColumnType("longtext");

                    b.Property<string>("ForeignArtistId")
                        .HasColumnType("longtext");

                    b.Property<bool>("Monitored")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("LidarrArtistCache");
                });

            modelBuilder.Entity("Ombi.Store.Entities.PlexEpisode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("EpisodeNumber")
                        .HasColumnType("int");

                    b.Property<int>("GrandparentKey")
                        .HasColumnType("int");

                    b.Property<int>("Key")
                        .HasColumnType("int");

                    b.Property<int>("ParentKey")
                        .HasColumnType("int");

                    b.Property<int>("SeasonNumber")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("GrandparentKey");

                    b.ToTable("PlexEpisode");
                });

            modelBuilder.Entity("Ombi.Store.Entities.PlexSeasonsContent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ParentKey")
                        .HasColumnType("int");

                    b.Property<int>("PlexContentId")
                        .HasColumnType("int");

                    b.Property<int?>("PlexServerContentId")
                        .HasColumnType("int");

                    b.Property<int>("SeasonKey")
                        .HasColumnType("int");

                    b.Property<int>("SeasonNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlexServerContentId");

                    b.ToTable("PlexSeasonsContent");
                });

            modelBuilder.Entity("Ombi.Store.Entities.PlexServerContent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("AddedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ImdbId")
                        .HasColumnType("longtext");

                    b.Property<int>("Key")
                        .HasColumnType("int");

                    b.Property<string>("Quality")
                        .HasColumnType("longtext");

                    b.Property<string>("ReleaseYear")
                        .HasColumnType("longtext");

                    b.Property<int?>("RequestId")
                        .HasColumnType("int");

                    b.Property<string>("TheMovieDbId")
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .HasColumnType("longtext");

                    b.Property<string>("TvDbId")
                        .HasColumnType("longtext");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("PlexServerContent");
                });

            modelBuilder.Entity("Ombi.Store.Entities.RadarrCache", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("HasFile")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("TheMovieDbId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("RadarrCache");
                });

            modelBuilder.Entity("Ombi.Store.Entities.SickRageCache", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("TvDbId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SickRageCache");
                });

            modelBuilder.Entity("Ombi.Store.Entities.SickRageEpisodeCache", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("EpisodeNumber")
                        .HasColumnType("int");

                    b.Property<int>("SeasonNumber")
                        .HasColumnType("int");

                    b.Property<int>("TvDbId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SickRageEpisodeCache");
                });

            modelBuilder.Entity("Ombi.Store.Entities.SonarrCache", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("TvDbId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SonarrCache");
                });

            modelBuilder.Entity("Ombi.Store.Entities.SonarrEpisodeCache", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("EpisodeNumber")
                        .HasColumnType("int");

                    b.Property<bool>("HasFile")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("SeasonNumber")
                        .HasColumnType("int");

                    b.Property<int>("TvDbId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SonarrEpisodeCache");
                });

            modelBuilder.Entity("Ombi.Store.Entities.EmbyEpisode", b =>
                {
                    b.HasOne("Ombi.Store.Entities.EmbyContent", "Series")
                        .WithMany("Episodes")
                        .HasForeignKey("ParentId")
                        .HasPrincipalKey("EmbyId");

                    b.Navigation("Series");
                });

            modelBuilder.Entity("Ombi.Store.Entities.JellyfinEpisode", b =>
                {
                    b.HasOne("Ombi.Store.Entities.JellyfinContent", "Series")
                        .WithMany("Episodes")
                        .HasForeignKey("ParentId")
                        .HasPrincipalKey("JellyfinId");

                    b.Navigation("Series");
                });

            modelBuilder.Entity("Ombi.Store.Entities.PlexEpisode", b =>
                {
                    b.HasOne("Ombi.Store.Entities.PlexServerContent", "Series")
                        .WithMany("Episodes")
                        .HasForeignKey("GrandparentKey")
                        .HasPrincipalKey("Key")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Series");
                });

            modelBuilder.Entity("Ombi.Store.Entities.PlexSeasonsContent", b =>
                {
                    b.HasOne("Ombi.Store.Entities.PlexServerContent", null)
                        .WithMany("Seasons")
                        .HasForeignKey("PlexServerContentId");
                });

            modelBuilder.Entity("Ombi.Store.Entities.EmbyContent", b =>
                {
                    b.Navigation("Episodes");
                });

            modelBuilder.Entity("Ombi.Store.Entities.JellyfinContent", b =>
                {
                    b.Navigation("Episodes");
                });

            modelBuilder.Entity("Ombi.Store.Entities.PlexServerContent", b =>
                {
                    b.Navigation("Episodes");

                    b.Navigation("Seasons");
                });
#pragma warning restore 612, 618
        }
    }
}
