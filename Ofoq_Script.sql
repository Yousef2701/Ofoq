USE [master]
GO

/****** Object:  Database [Ofoq-DB]    Script Date: 4/22/2025 3:17:26 PM ******/
CREATE DATABASE [Ofoq-DB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Ofoq-DB', FILENAME = N'C:\Users\Joe\Ofoq-DB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Ofoq-DB_log', FILENAME = N'C:\Users\Joe\Ofoq-DB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

USE [Ofoq-DB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 4/22/2025 3:21:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 4/22/2025 3:21:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 4/22/2025 3:21:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 4/22/2025 3:21:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 4/22/2025 3:21:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 4/22/2025 3:21:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 4/22/2025 3:21:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 4/22/2025 3:21:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 4/22/2025 3:21:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[TeacherId] [nvarchar](450) NOT NULL,
	[Title] [nvarchar](125) NOT NULL,
	[Academy_Year] [nvarchar](18) NOT NULL,
	[FileUrl] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED 
(
	[TeacherId] ASC,
	[Title] ASC,
	[Academy_Year] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Chapters]    Script Date: 4/22/2025 3:21:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chapters](
	[TeacherId] [nvarchar](450) NOT NULL,
	[Title] [nvarchar](125) NOT NULL,
 CONSTRAINT [PK_Chapters] PRIMARY KEY CLUSTERED 
(
	[TeacherId] ASC,
	[Title] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Enrollments]    Script Date: 4/22/2025 3:21:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Enrollments](
	[StudentId] [nvarchar](450) NOT NULL,
	[TeacherId] [nvarchar](450) NOT NULL,
	[Subject] [nvarchar](45) NOT NULL,
 CONSTRAINT [PK_Enrollments] PRIMARY KEY CLUSTERED 
(
	[TeacherId] ASC,
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExamQuestions]    Script Date: 4/22/2025 3:21:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExamQuestions](
	[ExamTitle] [nvarchar](125) NOT NULL,
	[TeacherId] [nvarchar](450) NOT NULL,
	[Academy_Year] [nvarchar](18) NOT NULL,
	[Quest] [nvarchar](185) NOT NULL,
	[Quest_Type] [nvarchar](5) NOT NULL,
	[Frist_Answer] [nvarchar](max) NOT NULL,
	[Second_Answer] [nvarchar](max) NOT NULL,
	[Third_Answer] [nvarchar](max) NOT NULL,
	[Forth_Answer] [nvarchar](max) NOT NULL,
	[Correct_Answer] [nvarchar](6) NOT NULL,
 CONSTRAINT [PK_ExamQuestions] PRIMARY KEY CLUSTERED 
(
	[TeacherId] ASC,
	[ExamTitle] ASC,
	[Academy_Year] ASC,
	[Quest] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExamResults]    Script Date: 4/22/2025 3:21:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExamResults](
	[ExamTitle] [nvarchar](185) NOT NULL,
	[TeacherId] [nvarchar](450) NOT NULL,
	[StudentId] [nvarchar](450) NOT NULL,
	[Date] [nvarchar](10) NOT NULL,
	[Time] [nvarchar](12) NOT NULL,
	[Correct_Answers_No] [int] NOT NULL,
 CONSTRAINT [PK_ExamResults] PRIMARY KEY CLUSTERED 
(
	[TeacherId] ASC,
	[ExamTitle] ASC,
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Exams]    Script Date: 4/22/2025 3:21:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Exams](
	[Title] [nvarchar](125) NOT NULL,
	[TeacherId] [nvarchar](450) NOT NULL,
	[Academy_Year] [nvarchar](50) NOT NULL,
	[Exam_Duration] [nvarchar](3) NOT NULL,
	[StartExamDate] [datetime2](7) NOT NULL,
	[FinishExamDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Exams] PRIMARY KEY CLUSTERED 
(
	[TeacherId] ASC,
	[Title] ASC,
	[Academy_Year] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LessonQuestions]    Script Date: 4/22/2025 3:21:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LessonQuestions](
	[Vedio_Url] [nvarchar](450) NOT NULL,
	[Quest] [nvarchar](185) NOT NULL,
	[Quest_Type] [nvarchar](5) NOT NULL,
	[Frist_Answer] [nvarchar](max) NOT NULL,
	[Second_Answer] [nvarchar](max) NOT NULL,
	[Third_Answer] [nvarchar](max) NOT NULL,
	[Forth_Answer] [nvarchar](max) NOT NULL,
	[Correct_Answer] [nvarchar](6) NOT NULL,
 CONSTRAINT [PK_LessonQuestions] PRIMARY KEY CLUSTERED 
(
	[Vedio_Url] ASC,
	[Quest] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lessons]    Script Date: 4/22/2025 3:21:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lessons](
	[TeacherId] [nvarchar](450) NOT NULL,
	[ChapterTitle] [nvarchar](125) NOT NULL,
	[Title] [nvarchar](125) NOT NULL,
	[Vedio_Url] [nvarchar](max) NOT NULL,
	[Date] [nvarchar](10) NOT NULL,
	[Time] [nvarchar](12) NOT NULL,
	[Am_Pm] [nvarchar](6) NOT NULL,
	[Academy_Year] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Lessons] PRIMARY KEY CLUSTERED 
(
	[TeacherId] ASC,
	[ChapterTitle] ASC,
	[Title] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LTestResults]    Script Date: 4/22/2025 3:21:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LTestResults](
	[Vedio_Url] [nvarchar](450) NOT NULL,
	[StudentId] [nvarchar](450) NOT NULL,
	[Date] [nvarchar](10) NOT NULL,
	[Time] [nvarchar](12) NOT NULL,
	[Correct_Answers_No] [int] NOT NULL,
 CONSTRAINT [PK_LTestResults] PRIMARY KEY CLUSTERED 
(
	[Vedio_Url] ASC,
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 4/22/2025 3:21:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](55) NOT NULL,
	[Phone] [nvarchar](11) NOT NULL,
	[Grade] [nvarchar](20) NOT NULL,
	[Department] [nvarchar](30) NOT NULL,
	[SecondLang] [nvarchar](20) NOT NULL,
	[Par_Phone] [nvarchar](11) NOT NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subjects]    Script Date: 4/22/2025 3:21:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subjects](
	[Numbre] [int] IDENTITY(1,1) NOT NULL,
	[Grade] [nvarchar](20) NOT NULL,
	[Department] [nvarchar](30) NOT NULL,
	[Name] [nvarchar](70) NOT NULL,
	[ImageUrl] [nvarchar](max) NULL,
 CONSTRAINT [PK_Subjects] PRIMARY KEY CLUSTERED 
(
	[Numbre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teachers]    Script Date: 4/22/2025 3:21:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teachers](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](55) NOT NULL,
	[Subject] [nvarchar](45) NOT NULL,
	[Phone] [nvarchar](11) NOT NULL,
	[First] [bit] NOT NULL,
	[Second] [bit] NOT NULL,
	[Third] [bit] NOT NULL,
	[Image_Url] [nvarchar](max) NULL,
 CONSTRAINT [PK_Teachers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'00000000000000_CreateIdentitySchema', N'6.0.29')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240708125428_Migration-1-CreateStudentAndTeacherAndEnrollmentTables', N'6.0.29')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240708130406_Migration-2-AddChapterTable', N'6.0.29')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240708131828_Migration-3-AddLessonTable', N'6.0.29')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240708132300_Migration-4-AddLessonTestTable', N'6.0.29')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240708132804_Migration-5-DeleteTeacherIdColumnFromLessonTestTable', N'6.0.29')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240708133313_Migration-6-CreateLTestResultTable', N'6.0.29')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240708133604_Migration-7-CreateLessonExamTable', N'6.0.29')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240708133929_Migration-7-CreateLExamResultTable', N'6.0.29')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240708134649_Migration-8-CreateGeneralExamTable', N'6.0.29')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240708135057_Migration-9-CreateGeneralExamQuestionTable', N'6.0.29')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240708135704_Migration-10-CreateGeneralExamResultTable', N'6.0.29')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240708140026_Migration-11-CreateBookTable', N'6.0.29')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240708150732_Migration-12-DeleteStudentImage', N'6.0.29')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240708171553_Migration-13-AddSubjectTable', N'6.0.29')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241021174728_Migration-14-RemoveLessonExamTable', N'6.0.29')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241021184803_Migration-15-AddStartAndFinishExamDate', N'6.0.29')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241023191021_Migration-16-AddForthAnswer', N'6.0.29')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241030104626_Migration-17-UpdateGeneralExamTable', N'6.0.29')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241030105556_Migration-18-UpdateGeneralExamQuestionTable', N'6.0.29')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241030112706_Migration-19-UpdateTablesName', N'6.0.29')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241030120656_Migration-20-UpdateLessonQuestionTable', N'6.0.29')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241031063553_Migration-21-UpdateQuestionsTable', N'6.0.29')
GO
SET IDENTITY_INSERT [dbo].[AspNetUserClaims] ON 

INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (15, N'cab244ed-6bb3-4ae0-98c1-5445b2c37ddb', N'Admin', N'Admin')
INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (16, N'891cf7c4-47be-49ef-af4c-057ce1cd443f', N'Teacher', N'Teacher')
INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (17, N'37c97fa6-f97d-44a6-8dea-327eff3174b8', N'Teacher', N'Teacher')
INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (18, N'7532ed3a-f0b1-46a5-a5d6-e36bdbfa9222', N'Teacher', N'Teacher')
INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (19, N'e87abb7b-2996-40b9-a4db-6e6e6b09cf85', N'Teacher', N'Teacher')
INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (20, N'd23a6e6f-d191-48d2-b99d-723419a6226c', N'Teacher', N'Teacher')
INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (23, N'75298497-e9f5-47e9-9afe-0cee28f6fcd7', N'Teacher', N'Teacher')
INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (24, N'ad4b5462-0063-4aec-a045-61c6f1b56206', N'Teacher', N'Teacher')
INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (25, N'33ee23ac-b136-40c9-9776-01adb3cc8433', N'Teacher', N'Teacher')
INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (26, N'2000874b-0597-49a2-9959-d0ebf2953d39', N'Teacher', N'Teacher')
INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (27, N'c36d3dbf-2818-400e-b153-715bfb8e1adb', N'Teacher', N'Teacher')
INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (28, N'e827d91d-dbd4-4e27-9070-07ee9a4bd2cc', N'Student', N'Student')
INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (29, N'2393fd65-962f-431a-a8fd-1b94381ac54b', N'Student', N'Student')
INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (30, N'c48468ff-73c3-4675-a17a-137549fc053a', N'Student', N'Student')
INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (31, N'5768061c-4a30-4154-9cd7-d8cd5c197558', N'Student', N'Student')
INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (32, N'2ea787ab-5100-4dd5-ba82-f8910150f55c', N'Student', N'Student')
INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (33, N'de0a869f-3515-4648-9b07-951a177b686b', N'Student', N'Student')
SET IDENTITY_INSERT [dbo].[AspNetUserClaims] OFF
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'2000874b-0597-49a2-9959-d0ebf2953d39', N'0595900874@gmail.com', N'0595900874@GMAIL.COM', N'0595900874@gmail.com', N'0595900874@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEAnmCdJKNNsZQN7rI8g88nUGghKn6gNrbwqBv8H/BVBImS8Okghu82cjKTFV3Ah82g==', N'5TRXKLEGNV5BBILGWIY4C4PUV6VYTZ5I', N'3e6131d4-dc02-4cfc-9eeb-524fdc4faddf', N'0595900874', 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'2393fd65-962f-431a-a8fd-1b94381ac54b', N'0551514721@gmail.com', N'0551514721@GMAIL.COM', N'0551514721@gmail.com', N'0551514721@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEOajJ2V4pGR1dJq0ZBZZRTniu8RMTU1xPuouTrL/eIQYnqSlqFwtp54+rQEaTEvMWA==', N'GOAVRDGYMZBS7JORQSWRHKCMHHLO7H7N', N'35051758-f170-4310-861e-db0afa4a0c70', N'0551514721', 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'2ea787ab-5100-4dd5-ba82-f8910150f55c', N'0551514732@gmail.com', N'0551514732@GMAIL.COM', N'0551514732@gmail.com', N'0551514732@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEAAFh2c8XPgY9GiayXkm5Wb7zhzef7yq8gtzkzSKwBONoKzRFfmsGkSh1vRxI3SkGw==', N'53RYE3XKS3LKUE6L2PELPLHSJP35DRQJ', N'e0db9ac7-0c3a-407d-8d27-928733ca0521', N'0551514732', 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'33ee23ac-b136-40c9-9776-01adb3cc8433', N'0543902020@gmail.com', N'0543902020@GMAIL.COM', N'0543902020@gmail.com', N'0543902020@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEOHCv4+9aBCmU1svazDSuFvf4kRHRMUbBt+u9psCC/M983khKvDTvFmrBwvdvW07IA==', N'ZCBMETZ5AGH7SGUR6YVR4YOM2H6DGREJ', N'9c5dff04-8fed-4820-b4b5-4cd9e7cac4e4', N'0543902020', 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'37c97fa6-f97d-44a6-8dea-327eff3174b8', N'0578900524@gmail.com', N'0578900524@GMAIL.COM', N'0578900524@gmail.com', N'0578900524@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEANqtCZQ4ZfyBfYA1j1wVueAasSgTw+RATOaSWWZdalW6TGJ9Dq08kQZnuxrgthsPQ==', N'6BVUF57LTFMANMOA76VMXPLN75JIXHEN', N'0366a598-4e3b-40d7-8563-260b1da20cce', N'0578900524', 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'5768061c-4a30-4154-9cd7-d8cd5c197558', N'0551514731@gmail.com', N'0551514731@GMAIL.COM', N'0551514731@gmail.com', N'0551514731@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEOrt3r3s7Rzxcni29uGu+EQ5GgAIW/zY5cVPNSNo7M71oegYJwOP6devbogB8h6acw==', N'DRRRFTTK3QYWFRFK657AU26YUGFK3Z6S', N'4e24759d-ab76-4467-bea3-c93c659eb732', N'0551514731', 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'75298497-e9f5-47e9-9afe-0cee28f6fcd7', N'0551528007@gmail.com', N'0551528007@GMAIL.COM', N'0551528007@gmail.com', N'0551528007@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEDdzpRl8x+KajdqW1TWAYzijhrtGUlwQcIMYfVKQczyVH6rLmUxiQ5lH42JDpY1CZA==', N'FWGY6PWCLSZQKUATLB3SEPLWUREVMGBY', N'9337443c-58c2-4671-ae40-4bf02d6543a4', N'0551528007', 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'7532ed3a-f0b1-46a5-a5d6-e36bdbfa9222', N'0589666800@gmail.com', N'0589666800@GMAIL.COM', N'0589666800@gmail.com', N'0589666800@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEANl6Lm/vjUGuRpO8geVpAz6/Ema/FPr61CAv4wUoaOPmVN36Ef0zgqXGICN2ptIUQ==', N'KPITQKQ4M5WJO3CUIZ7DZCYLH3FRW26Z', N'573bb10f-9d5d-4058-9852-c4d36e5e309f', N'0589666800', 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'891cf7c4-47be-49ef-af4c-057ce1cd443f', N'0558237410@gmail.com', N'0558237410@GMAIL.COM', N'0558237410@gmail.com', N'0558237410@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEItYf4eRBgIvG6Ih72l4qQ7rncu/bF1nzixQAodiBqOKbNmlIUzYJKK0Sd+Up+eXbw==', N'BG2LNNCJPWWIA7LSVEJIYIPI4XMLY5P7', N'0f5dfa0d-5000-41cc-990e-6739e29b70b1', N'0558237410', 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'ad4b5462-0063-4aec-a045-61c6f1b56206', N'0583300741@gmail.com', N'0583300741@GMAIL.COM', N'0583300741@gmail.com', N'0583300741@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEHLqQa1FNnrTtpxMipIFqXGQClWSQdPNxtgjOTFbD/mnpCPJM/J/SIR4KhgUF5Amnw==', N'BGQEIDRKEH45JMXB6YFBWKMVRYSTVCR6', N'8fa017bf-8b09-4685-bc1d-a6598ba425d4', N'0583300741', 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'c36d3dbf-2818-400e-b153-715bfb8e1adb', N'0502435786@gmail.com', N'0502435786@GMAIL.COM', N'0502435786@gmail.com', N'0502435786@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEN4m9gwuJ0G2mgkI/hqWzlM8eadji0VjaQlcPuapfcKaknL/wBoIgjToP3QNjIhdsg==', N'YY5BUSNM3VBVTZQC2BDRJBPWVZVFNKG6', N'd913e5a7-1274-4ccc-a675-c67388f8e85f', N'0502435786', 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'c48468ff-73c3-4675-a17a-137549fc053a', N'0551514722@gmail.com', N'0551514722@GMAIL.COM', N'0551514722@gmail.com', N'0551514722@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEDnFZizOUUEVvKrvYT2p2MyANgxub5f+MTyhZJuFgPuX66g9Ajs0Kx0jC5QAG1e+CA==', N'UOGRJPDGGXHFIZSJ6XQLWO33WBJF5AI5', N'3e39f40a-e24f-4120-8cf4-f84b4135187c', N'0551514722', 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'cab244ed-6bb3-4ae0-98c1-5445b2c37ddb', N'0551514744@gmail.com', N'0551514744@GMAIL.COM', N'0551514744@gmail.com', N'0551514744@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEOp+cmP+k4XUx3p5SNhma+oOfVDKZ6/v2GTU2sBumuSMVi4qOhRmRRFwzWPMkwrzqA==', N'VCQHBMSYGD7MNTP22BGJYNTQVNUKVMSV', N'58127e34-7244-472a-bb6d-6eea298251c9', N'0551514744', 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'd23a6e6f-d191-48d2-b99d-723419a6226c', N'0588200465@gmail.com', N'0588200465@GMAIL.COM', N'0588200465@gmail.com', N'0588200465@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEDPfxXGG3HJrO99gJrVaJ2Ir7rv2FNUUrVf3Ap6ho8rgUF8f4A5akxSFqwcyfs/XyA==', N'SEJTFPXNRRF24LG7MI6UCEJPPM3LH3DR', N'09a0c26f-ea37-473d-9681-e8de66eb7426', N'0588200465', 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'de0a869f-3515-4648-9b07-951a177b686b', N'0551514733@gmail.com', N'0551514733@GMAIL.COM', N'0551514733@gmail.com', N'0551514733@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEDzZk/AgfFCKTM6mQ1/+3YI68zxmyFUS9XkDLypZ7mARdPxW0qhowe6ZleZs9ZTIJw==', N'3QADL2HCZM7NIJM42TKJSJJCQ4452VSI', N'78bc2d51-15c5-4b9a-871d-a632c36fd488', N'0551514733', 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'e827d91d-dbd4-4e27-9070-07ee9a4bd2cc', N'0551514711@gmail.com', N'0551514711@GMAIL.COM', N'0551514711@gmail.com', N'0551514711@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAECFEX0d759QWKtUkQ1GyIm5j6I1FprG350umAZQGYbwdLRUB/Tunn/ENmSla+f+J2w==', N'GFK7IHNVF7X7AUXOVPY5KVBROWK32OZM', N'92032232-d203-40e2-a35e-7d6958073d7b', N'0551514711', 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'e87abb7b-2996-40b9-a4db-6e6e6b09cf85', N'0553241520@gmail.com', N'0553241520@GMAIL.COM', N'0553241520@gmail.com', N'0553241520@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEJ+LiU5xCw2VkWHKpNiMN2l6+aTb4PcxSqC834R14HIcyp5XG8fzf/TdF0yfm4drKg==', N'5UT3CIGRHAH5I7GU6TBMRXSU3HZJFTQ3', N'd9966d22-af7c-47d8-be25-9fbc64b5cb6d', N'0553241520', 0, 0, NULL, 1, 0)
GO
INSERT [dbo].[Chapters] ([TeacherId], [Title]) VALUES (N'e87abb7b-2996-40b9-a4db-6e6e6b09cf85', N'الكيمياء التحليلية')
INSERT [dbo].[Chapters] ([TeacherId], [Title]) VALUES (N'e87abb7b-2996-40b9-a4db-6e6e6b09cf85', N'الكيمياء العضوية')
INSERT [dbo].[Chapters] ([TeacherId], [Title]) VALUES (N'e87abb7b-2996-40b9-a4db-6e6e6b09cf85', N'الكيمياء الكهربائية')
GO
INSERT [dbo].[Enrollments] ([StudentId], [TeacherId], [Subject]) VALUES (N'2393fd65-962f-431a-a8fd-1b94381ac54b', N'33ee23ac-b136-40c9-9776-01adb3cc8433', N'التاريخ')
INSERT [dbo].[Enrollments] ([StudentId], [TeacherId], [Subject]) VALUES (N'5768061c-4a30-4154-9cd7-d8cd5c197558', N'33ee23ac-b136-40c9-9776-01adb3cc8433', N'التاريخ')
INSERT [dbo].[Enrollments] ([StudentId], [TeacherId], [Subject]) VALUES (N'e827d91d-dbd4-4e27-9070-07ee9a4bd2cc', N'33ee23ac-b136-40c9-9776-01adb3cc8433', N'التاريخ')
INSERT [dbo].[Enrollments] ([StudentId], [TeacherId], [Subject]) VALUES (N'2393fd65-962f-431a-a8fd-1b94381ac54b', N'37c97fa6-f97d-44a6-8dea-327eff3174b8', N'اللغة العربية')
INSERT [dbo].[Enrollments] ([StudentId], [TeacherId], [Subject]) VALUES (N'2ea787ab-5100-4dd5-ba82-f8910150f55c', N'37c97fa6-f97d-44a6-8dea-327eff3174b8', N'اللغة العربية')
INSERT [dbo].[Enrollments] ([StudentId], [TeacherId], [Subject]) VALUES (N'5768061c-4a30-4154-9cd7-d8cd5c197558', N'37c97fa6-f97d-44a6-8dea-327eff3174b8', N'اللغة العربية')
INSERT [dbo].[Enrollments] ([StudentId], [TeacherId], [Subject]) VALUES (N'c48468ff-73c3-4675-a17a-137549fc053a', N'37c97fa6-f97d-44a6-8dea-327eff3174b8', N'اللغة العربية')
INSERT [dbo].[Enrollments] ([StudentId], [TeacherId], [Subject]) VALUES (N'de0a869f-3515-4648-9b07-951a177b686b', N'37c97fa6-f97d-44a6-8dea-327eff3174b8', N'اللغة العربية')
INSERT [dbo].[Enrollments] ([StudentId], [TeacherId], [Subject]) VALUES (N'e827d91d-dbd4-4e27-9070-07ee9a4bd2cc', N'37c97fa6-f97d-44a6-8dea-327eff3174b8', N'اللغة العربية')
INSERT [dbo].[Enrollments] ([StudentId], [TeacherId], [Subject]) VALUES (N'2393fd65-962f-431a-a8fd-1b94381ac54b', N'75298497-e9f5-47e9-9afe-0cee28f6fcd7', N'اللغة الفرنسية')
INSERT [dbo].[Enrollments] ([StudentId], [TeacherId], [Subject]) VALUES (N'2ea787ab-5100-4dd5-ba82-f8910150f55c', N'75298497-e9f5-47e9-9afe-0cee28f6fcd7', N'اللغة الفرنسية')
INSERT [dbo].[Enrollments] ([StudentId], [TeacherId], [Subject]) VALUES (N'5768061c-4a30-4154-9cd7-d8cd5c197558', N'75298497-e9f5-47e9-9afe-0cee28f6fcd7', N'اللغة الفرنسية')
INSERT [dbo].[Enrollments] ([StudentId], [TeacherId], [Subject]) VALUES (N'c48468ff-73c3-4675-a17a-137549fc053a', N'75298497-e9f5-47e9-9afe-0cee28f6fcd7', N'اللغة الفرنسية')
INSERT [dbo].[Enrollments] ([StudentId], [TeacherId], [Subject]) VALUES (N'de0a869f-3515-4648-9b07-951a177b686b', N'75298497-e9f5-47e9-9afe-0cee28f6fcd7', N'اللغة الفرنسية')
INSERT [dbo].[Enrollments] ([StudentId], [TeacherId], [Subject]) VALUES (N'e827d91d-dbd4-4e27-9070-07ee9a4bd2cc', N'75298497-e9f5-47e9-9afe-0cee28f6fcd7', N'اللغة الفرنسية')
INSERT [dbo].[Enrollments] ([StudentId], [TeacherId], [Subject]) VALUES (N'2393fd65-962f-431a-a8fd-1b94381ac54b', N'7532ed3a-f0b1-46a5-a5d6-e36bdbfa9222', N'اللغة الانجليزية')
INSERT [dbo].[Enrollments] ([StudentId], [TeacherId], [Subject]) VALUES (N'2ea787ab-5100-4dd5-ba82-f8910150f55c', N'7532ed3a-f0b1-46a5-a5d6-e36bdbfa9222', N'اللغة الانجليزية')
INSERT [dbo].[Enrollments] ([StudentId], [TeacherId], [Subject]) VALUES (N'5768061c-4a30-4154-9cd7-d8cd5c197558', N'7532ed3a-f0b1-46a5-a5d6-e36bdbfa9222', N'اللغة الانجليزية')
INSERT [dbo].[Enrollments] ([StudentId], [TeacherId], [Subject]) VALUES (N'c48468ff-73c3-4675-a17a-137549fc053a', N'7532ed3a-f0b1-46a5-a5d6-e36bdbfa9222', N'اللغة الانجليزية')
INSERT [dbo].[Enrollments] ([StudentId], [TeacherId], [Subject]) VALUES (N'de0a869f-3515-4648-9b07-951a177b686b', N'7532ed3a-f0b1-46a5-a5d6-e36bdbfa9222', N'اللغة الانجليزية')
INSERT [dbo].[Enrollments] ([StudentId], [TeacherId], [Subject]) VALUES (N'e827d91d-dbd4-4e27-9070-07ee9a4bd2cc', N'7532ed3a-f0b1-46a5-a5d6-e36bdbfa9222', N'اللغة الانجليزية')
INSERT [dbo].[Enrollments] ([StudentId], [TeacherId], [Subject]) VALUES (N'2ea787ab-5100-4dd5-ba82-f8910150f55c', N'ad4b5462-0063-4aec-a045-61c6f1b56206', N'الفيزياء')
INSERT [dbo].[Enrollments] ([StudentId], [TeacherId], [Subject]) VALUES (N'c48468ff-73c3-4675-a17a-137549fc053a', N'ad4b5462-0063-4aec-a045-61c6f1b56206', N'الفيزياء')
INSERT [dbo].[Enrollments] ([StudentId], [TeacherId], [Subject]) VALUES (N'e827d91d-dbd4-4e27-9070-07ee9a4bd2cc', N'ad4b5462-0063-4aec-a045-61c6f1b56206', N'الفيزياء')
INSERT [dbo].[Enrollments] ([StudentId], [TeacherId], [Subject]) VALUES (N'2393fd65-962f-431a-a8fd-1b94381ac54b', N'c36d3dbf-2818-400e-b153-715bfb8e1adb', N'علم النفس و الاجتماع')
INSERT [dbo].[Enrollments] ([StudentId], [TeacherId], [Subject]) VALUES (N'5768061c-4a30-4154-9cd7-d8cd5c197558', N'c36d3dbf-2818-400e-b153-715bfb8e1adb', N'علم النفس و الاجتماع')
INSERT [dbo].[Enrollments] ([StudentId], [TeacherId], [Subject]) VALUES (N'de0a869f-3515-4648-9b07-951a177b686b', N'd23a6e6f-d191-48d2-b99d-723419a6226c', N'رياضيات')
INSERT [dbo].[Enrollments] ([StudentId], [TeacherId], [Subject]) VALUES (N'2ea787ab-5100-4dd5-ba82-f8910150f55c', N'e87abb7b-2996-40b9-a4db-6e6e6b09cf85', N'الكيمياء')
INSERT [dbo].[Enrollments] ([StudentId], [TeacherId], [Subject]) VALUES (N'c48468ff-73c3-4675-a17a-137549fc053a', N'e87abb7b-2996-40b9-a4db-6e6e6b09cf85', N'الكيمياء')
INSERT [dbo].[Enrollments] ([StudentId], [TeacherId], [Subject]) VALUES (N'e827d91d-dbd4-4e27-9070-07ee9a4bd2cc', N'e87abb7b-2996-40b9-a4db-6e6e6b09cf85', N'الكيمياء')
GO
INSERT [dbo].[LessonQuestions] ([Vedio_Url], [Quest], [Quest_Type], [Frist_Answer], [Second_Answer], [Third_Answer], [Forth_Answer], [Correct_Answer]) VALUES (N'0553241520الألكاناتRecording 2025-04-22 115055.mp4', N'السؤال 1 ', N'Text', N'الاجابة 1', N'الاجابة 2', N'الاجابة 3', N'الاجابة 4', N'3')
INSERT [dbo].[LessonQuestions] ([Vedio_Url], [Quest], [Quest_Type], [Frist_Answer], [Second_Answer], [Third_Answer], [Forth_Answer], [Correct_Answer]) VALUES (N'0553241520الألكاناتRecording 2025-04-22 115055.mp4', N'السؤال 2 ', N'Text', N'الاجابة 1', N'الاجابة 2', N'الاجابة 3', N'الاجابة 4', N'4')
INSERT [dbo].[LessonQuestions] ([Vedio_Url], [Quest], [Quest_Type], [Frist_Answer], [Second_Answer], [Third_Answer], [Forth_Answer], [Correct_Answer]) VALUES (N'0553241520الألكاناتRecording 2025-04-22 115055.mp4', N'السؤال 3 ', N'Text', N'الاجابة 1', N'الاجابة 2', N'الاجابة 3', N'الاجابة 4', N'1')
INSERT [dbo].[LessonQuestions] ([Vedio_Url], [Quest], [Quest_Type], [Frist_Answer], [Second_Answer], [Third_Answer], [Forth_Answer], [Correct_Answer]) VALUES (N'0553241520الألكاناتRecording 2025-04-22 115055.mp4', N'السؤال 4', N'Text', N'الاجابة 1', N'الاجابة 2', N'الاجابة 3', N'الاجابة 4', N'2')
INSERT [dbo].[LessonQuestions] ([Vedio_Url], [Quest], [Quest_Type], [Frist_Answer], [Second_Answer], [Third_Answer], [Forth_Answer], [Correct_Answer]) VALUES (N'0553241520الألكاناتRecording 2025-04-22 115055.mp4', N'السؤال 5', N'Text', N'الاجابة 1', N'الاجابة 2', N'الاجابة 3', N'الاجابة 4', N'1')
INSERT [dbo].[LessonQuestions] ([Vedio_Url], [Quest], [Quest_Type], [Frist_Answer], [Second_Answer], [Third_Answer], [Forth_Answer], [Correct_Answer]) VALUES (N'0553241520الألكاناتRecording 2025-04-22 115055.mp4', N'السؤال 6', N'Text', N'الاجابة 1', N'الاجابة 2', N'الاجابة 3', N'الاجابة 4', N'4')
INSERT [dbo].[LessonQuestions] ([Vedio_Url], [Quest], [Quest_Type], [Frist_Answer], [Second_Answer], [Third_Answer], [Forth_Answer], [Correct_Answer]) VALUES (N'0553241520الألكايناتRecording 2025-04-22 115055.mp4', N'السؤال 1', N'Text', N'الاجابة 1', N'الاجابة 2', N'الاجابة 3', N'الاجابة 4', N'2')
INSERT [dbo].[LessonQuestions] ([Vedio_Url], [Quest], [Quest_Type], [Frist_Answer], [Second_Answer], [Third_Answer], [Forth_Answer], [Correct_Answer]) VALUES (N'0553241520الألكايناتRecording 2025-04-22 115055.mp4', N'السؤال 2', N'Text', N'الاجابة 1', N'الاجابة 2', N'الاجابة 3', N'الاجابة 4', N'4')
INSERT [dbo].[LessonQuestions] ([Vedio_Url], [Quest], [Quest_Type], [Frist_Answer], [Second_Answer], [Third_Answer], [Forth_Answer], [Correct_Answer]) VALUES (N'0553241520الألكايناتRecording 2025-04-22 115055.mp4', N'السؤال 3', N'Text', N'الاجابة 1', N'الاجابة 2', N'الاجابة 3', N'الاجابة 4', N'4')
INSERT [dbo].[LessonQuestions] ([Vedio_Url], [Quest], [Quest_Type], [Frist_Answer], [Second_Answer], [Third_Answer], [Forth_Answer], [Correct_Answer]) VALUES (N'0553241520الألكايناتRecording 2025-04-22 115055.mp4', N'السؤال 4', N'Text', N'الاجابة 1', N'الاجابة 2', N'الاجابة 3', N'الاجابة 4', N'1')
INSERT [dbo].[LessonQuestions] ([Vedio_Url], [Quest], [Quest_Type], [Frist_Answer], [Second_Answer], [Third_Answer], [Forth_Answer], [Correct_Answer]) VALUES (N'0553241520الألكايناتRecording 2025-04-22 115055.mp4', N'السؤال 5', N'Text', N'الاجابة 1', N'الاجابة 2', N'الاجابة 3', N'الاجابة 4', N'3')
INSERT [dbo].[LessonQuestions] ([Vedio_Url], [Quest], [Quest_Type], [Frist_Answer], [Second_Answer], [Third_Answer], [Forth_Answer], [Correct_Answer]) VALUES (N'0553241520الألكيناتRecording 2025-04-22 115055.mp4', N'السؤال 1', N'Text', N'الاجابة 1', N'الاجابة 2', N'الاجابة 3', N'الاجابة 4', N'1')
INSERT [dbo].[LessonQuestions] ([Vedio_Url], [Quest], [Quest_Type], [Frist_Answer], [Second_Answer], [Third_Answer], [Forth_Answer], [Correct_Answer]) VALUES (N'0553241520الألكيناتRecording 2025-04-22 115055.mp4', N'السؤال 2', N'Text', N'الاجابة 1', N'الاجابة 2', N'الاجابة 3', N'الاجابة 4', N'4')
INSERT [dbo].[LessonQuestions] ([Vedio_Url], [Quest], [Quest_Type], [Frist_Answer], [Second_Answer], [Third_Answer], [Forth_Answer], [Correct_Answer]) VALUES (N'0553241520الألكيناتRecording 2025-04-22 115055.mp4', N'السؤال 3', N'Text', N'الاجابة 1', N'الاجابة 2', N'الاجابة 3', N'الاجابة 4', N'2')
INSERT [dbo].[LessonQuestions] ([Vedio_Url], [Quest], [Quest_Type], [Frist_Answer], [Second_Answer], [Third_Answer], [Forth_Answer], [Correct_Answer]) VALUES (N'0553241520الألكيناتRecording 2025-04-22 115055.mp4', N'السؤال 4', N'Text', N'الاجابة 1', N'الاجابة 2', N'الاجابة 3', N'الاجابة 4', N'2')
INSERT [dbo].[LessonQuestions] ([Vedio_Url], [Quest], [Quest_Type], [Frist_Answer], [Second_Answer], [Third_Answer], [Forth_Answer], [Correct_Answer]) VALUES (N'0553241520البنزين العطريRecording 2025-04-22 115055.mp4', N'السؤال 1', N'Text', N'الاجابة 1', N'الاجابة 2', N'الاجابة 3', N'الاجابة 4', N'2')
INSERT [dbo].[LessonQuestions] ([Vedio_Url], [Quest], [Quest_Type], [Frist_Answer], [Second_Answer], [Third_Answer], [Forth_Answer], [Correct_Answer]) VALUES (N'0553241520البنزين العطريRecording 2025-04-22 115055.mp4', N'السؤال 2', N'Text', N'الاجابة 1', N'الاجابة 2', N'الاجابة 3', N'الاجابة 4', N'4')
INSERT [dbo].[LessonQuestions] ([Vedio_Url], [Quest], [Quest_Type], [Frist_Answer], [Second_Answer], [Third_Answer], [Forth_Answer], [Correct_Answer]) VALUES (N'0553241520البنزين العطريRecording 2025-04-22 115055.mp4', N'السؤال 3', N'Text', N'الاجابة 1', N'الاجابة 2', N'الاجابة 3', N'الاجابة 4', N'1')
INSERT [dbo].[LessonQuestions] ([Vedio_Url], [Quest], [Quest_Type], [Frist_Answer], [Second_Answer], [Third_Answer], [Forth_Answer], [Correct_Answer]) VALUES (N'0553241520البنزين العطريRecording 2025-04-22 115055.mp4', N'السؤال 4', N'Text', N'الاجابة 1', N'الاجابة 2', N'الاجابة 3', N'الاجابة 4', N'4')
INSERT [dbo].[LessonQuestions] ([Vedio_Url], [Quest], [Quest_Type], [Frist_Answer], [Second_Answer], [Third_Answer], [Forth_Answer], [Correct_Answer]) VALUES (N'0553241520البنزين العطريRecording 2025-04-22 115055.mp4', N'السؤال 5', N'Text', N'الاجابة 1', N'الاجابة 2', N'الاجابة 3', N'الاجابة 4', N'1')
INSERT [dbo].[LessonQuestions] ([Vedio_Url], [Quest], [Quest_Type], [Frist_Answer], [Second_Answer], [Third_Answer], [Forth_Answer], [Correct_Answer]) VALUES (N'0553241520التحليل الكميRecording 2025-04-22 115055.mp4', N'السؤال 1', N'Text', N'الاجابة 1', N'الاجابة 2', N'الاجابة 3', N'الاجابة 4', N'1')
INSERT [dbo].[LessonQuestions] ([Vedio_Url], [Quest], [Quest_Type], [Frist_Answer], [Second_Answer], [Third_Answer], [Forth_Answer], [Correct_Answer]) VALUES (N'0553241520التحليل الكميRecording 2025-04-22 115055.mp4', N'السؤال 2', N'Text', N'الاجابة 1', N'الاجابة 2', N'الاجابة 3', N'الاجابة 4', N'2')
INSERT [dbo].[LessonQuestions] ([Vedio_Url], [Quest], [Quest_Type], [Frist_Answer], [Second_Answer], [Third_Answer], [Forth_Answer], [Correct_Answer]) VALUES (N'0553241520التحليل الكميRecording 2025-04-22 115055.mp4', N'السؤال 3', N'Text', N'الاجابة 1', N'الاجابة 2', N'الاجابة 3', N'الاجابة 4', N'1')
INSERT [dbo].[LessonQuestions] ([Vedio_Url], [Quest], [Quest_Type], [Frist_Answer], [Second_Answer], [Third_Answer], [Forth_Answer], [Correct_Answer]) VALUES (N'0553241520التحليل الكميRecording 2025-04-22 115055.mp4', N'السؤال 4', N'Text', N'الاجابة 1', N'الاجابة 2', N'الاجابة 3', N'الاجابة 4', N'4')
INSERT [dbo].[LessonQuestions] ([Vedio_Url], [Quest], [Quest_Type], [Frist_Answer], [Second_Answer], [Third_Answer], [Forth_Answer], [Correct_Answer]) VALUES (N'0553241520التحليل الكميRecording 2025-04-22 115055.mp4', N'السؤال 5', N'Text', N'الاجابة 1', N'الاجابة 2', N'الاجابة 3', N'الاجابة 4', N'1')
INSERT [dbo].[LessonQuestions] ([Vedio_Url], [Quest], [Quest_Type], [Frist_Answer], [Second_Answer], [Third_Answer], [Forth_Answer], [Correct_Answer]) VALUES (N'0553241520التحليل الكميRecording 2025-04-22 115055.mp4', N'السؤال 6', N'Text', N'الاجابة 1', N'الاجابة 2', N'الاجابة 3', N'الاجابة 4', N'1')
INSERT [dbo].[LessonQuestions] ([Vedio_Url], [Quest], [Quest_Type], [Frist_Answer], [Second_Answer], [Third_Answer], [Forth_Answer], [Correct_Answer]) VALUES (N'0553241520التحليل النوعيRecording 2025-04-22 115055.mp4', N'السؤال 1', N'Text', N'الاجابة 1', N'الاجابة 2', N'الاجابة 3', N'الاجابة 4', N'1')
INSERT [dbo].[LessonQuestions] ([Vedio_Url], [Quest], [Quest_Type], [Frist_Answer], [Second_Answer], [Third_Answer], [Forth_Answer], [Correct_Answer]) VALUES (N'0553241520التحليل النوعيRecording 2025-04-22 115055.mp4', N'السؤال 3', N'Text', N'الاجابة 1', N'الاجابة 2', N'الاجابة 3', N'الاجابة 4', N'1')
INSERT [dbo].[LessonQuestions] ([Vedio_Url], [Quest], [Quest_Type], [Frist_Answer], [Second_Answer], [Third_Answer], [Forth_Answer], [Correct_Answer]) VALUES (N'0553241520الخلايا الجلفانية و الالكتروليتيةRecording 2025-04-22 115055.mp4', N'السؤال 1', N'Text', N'الاجابة 1', N'الاجابة 2', N'الاجابة 3', N'الاجابة 4', N'1')
INSERT [dbo].[LessonQuestions] ([Vedio_Url], [Quest], [Quest_Type], [Frist_Answer], [Second_Answer], [Third_Answer], [Forth_Answer], [Correct_Answer]) VALUES (N'0553241520الخلايا الجلفانية و الالكتروليتيةRecording 2025-04-22 115055.mp4', N'السؤال 2', N'Text', N'الاجابة 1', N'الاجابة 2', N'الاجابة 3', N'الاجابة 4', N'4')
INSERT [dbo].[LessonQuestions] ([Vedio_Url], [Quest], [Quest_Type], [Frist_Answer], [Second_Answer], [Third_Answer], [Forth_Answer], [Correct_Answer]) VALUES (N'0553241520الخلايا الجلفانية و الالكتروليتيةRecording 2025-04-22 115055.mp4', N'السؤال 3', N'Text', N'الاجابة 1', N'الاجابة 2', N'الاجابة 3', N'الاجابة 4', N'4')
INSERT [dbo].[LessonQuestions] ([Vedio_Url], [Quest], [Quest_Type], [Frist_Answer], [Second_Answer], [Third_Answer], [Forth_Answer], [Correct_Answer]) VALUES (N'0553241520الخلايا الجلفانية و الالكتروليتيةRecording 2025-04-22 115055.mp4', N'السؤال 4', N'Text', N'الاجابة 1', N'الاجابة 2', N'الاجابة 3', N'الاجابة 4', N'3')
INSERT [dbo].[LessonQuestions] ([Vedio_Url], [Quest], [Quest_Type], [Frist_Answer], [Second_Answer], [Third_Answer], [Forth_Answer], [Correct_Answer]) VALUES (N'0553241520الخلايا الجلفانية و الالكتروليتيةRecording 2025-04-22 115055.mp4', N'السؤال 5', N'Text', N'الاجابة 1', N'الاجابة 2', N'الاجابة 3', N'الاجابة 4', N'1')
INSERT [dbo].[LessonQuestions] ([Vedio_Url], [Quest], [Quest_Type], [Frist_Answer], [Second_Answer], [Third_Answer], [Forth_Answer], [Correct_Answer]) VALUES (N'0553241520الخلايا الجلفانية و الالكتروليتيةRecording 2025-04-22 115055.mp4', N'السؤال 6', N'Text', N'الاجابة 1', N'الاجابة 2', N'الاجابة 3', N'الاجابة 4', N'3')
INSERT [dbo].[LessonQuestions] ([Vedio_Url], [Quest], [Quest_Type], [Frist_Answer], [Second_Answer], [Third_Answer], [Forth_Answer], [Correct_Answer]) VALUES (N'0553241520المعادلات النصف خلويةRecording 2025-04-22 115055.mp4', N'السؤال 1', N'Text', N'الاجابة 1', N'الاجابة 2', N'الاجابة 3', N'الاجابة 4', N'1')
INSERT [dbo].[LessonQuestions] ([Vedio_Url], [Quest], [Quest_Type], [Frist_Answer], [Second_Answer], [Third_Answer], [Forth_Answer], [Correct_Answer]) VALUES (N'0553241520المعادلات النصف خلويةRecording 2025-04-22 115055.mp4', N'السؤال 2', N'Text', N'الاجابة 1', N'الاجابة 2', N'الاجابة 3', N'الاجابة 4', N'3')
INSERT [dbo].[LessonQuestions] ([Vedio_Url], [Quest], [Quest_Type], [Frist_Answer], [Second_Answer], [Third_Answer], [Forth_Answer], [Correct_Answer]) VALUES (N'0553241520المعادلات النصف خلويةRecording 2025-04-22 115055.mp4', N'السؤال 3', N'Text', N'الاجابة 1', N'الاجابة 2', N'الاجابة 3', N'الاجابة 4', N'1')
INSERT [dbo].[LessonQuestions] ([Vedio_Url], [Quest], [Quest_Type], [Frist_Answer], [Second_Answer], [Third_Answer], [Forth_Answer], [Correct_Answer]) VALUES (N'0553241520تآكل المعادنRecording 2025-04-22 115055.mp4', N'السؤال 1', N'Text', N'الاجابة 1', N'الاجابة 2', N'الاجابة 3', N'الاجابة 4', N'4')
INSERT [dbo].[LessonQuestions] ([Vedio_Url], [Quest], [Quest_Type], [Frist_Answer], [Second_Answer], [Third_Answer], [Forth_Answer], [Correct_Answer]) VALUES (N'0553241520تآكل المعادنRecording 2025-04-22 115055.mp4', N'السؤال 2', N'Text', N'الاجابة 1', N'الاجابة 2', N'الاجابة 3', N'الاجابة 4', N'1')
INSERT [dbo].[LessonQuestions] ([Vedio_Url], [Quest], [Quest_Type], [Frist_Answer], [Second_Answer], [Third_Answer], [Forth_Answer], [Correct_Answer]) VALUES (N'0553241520تآكل المعادنRecording 2025-04-22 115055.mp4', N'السؤال 3', N'Text', N'الاجابة 1', N'الاجابة 2', N'الاجابة 3', N'الاجابة 4', N'1')
INSERT [dbo].[LessonQuestions] ([Vedio_Url], [Quest], [Quest_Type], [Frist_Answer], [Second_Answer], [Third_Answer], [Forth_Answer], [Correct_Answer]) VALUES (N'0553241520تآكل المعادنRecording 2025-04-22 115055.mp4', N'السؤال 4', N'Text', N'الاجابة 1', N'الاجابة 2', N'الاجابة 3', N'الاجابة 4', N'1')
INSERT [dbo].[LessonQuestions] ([Vedio_Url], [Quest], [Quest_Type], [Frist_Answer], [Second_Answer], [Third_Answer], [Forth_Answer], [Correct_Answer]) VALUES (N'0553241520حساب فرق الجهد القياسيRecording 2025-04-22 115055.mp4', N'السؤال 1', N'Text', N'الاجابة 1', N'الاجابة 2', N'الاجابة 3', N'الاجابة 4', N'1')
INSERT [dbo].[LessonQuestions] ([Vedio_Url], [Quest], [Quest_Type], [Frist_Answer], [Second_Answer], [Third_Answer], [Forth_Answer], [Correct_Answer]) VALUES (N'0553241520حساب فرق الجهد القياسيRecording 2025-04-22 115055.mp4', N'السؤال 2', N'Text', N'الاجابة 1', N'الاجابة 2', N'الاجابة 3', N'الاجابة 4', N'3')
INSERT [dbo].[LessonQuestions] ([Vedio_Url], [Quest], [Quest_Type], [Frist_Answer], [Second_Answer], [Third_Answer], [Forth_Answer], [Correct_Answer]) VALUES (N'0553241520حساب فرق الجهد القياسيRecording 2025-04-22 115055.mp4', N'السؤال 3', N'Text', N'الاجابة 1', N'الاجابة 2', N'الاجابة 3', N'الاجابة 4', N'2')
INSERT [dbo].[LessonQuestions] ([Vedio_Url], [Quest], [Quest_Type], [Frist_Answer], [Second_Answer], [Third_Answer], [Forth_Answer], [Correct_Answer]) VALUES (N'0553241520حساب فرق الجهد القياسيRecording 2025-04-22 115055.mp4', N'السؤال 4', N'Text', N'الاجابة 1', N'الاجابة 2', N'الاجابة 3', N'الاجابة 4', N'1')
INSERT [dbo].[LessonQuestions] ([Vedio_Url], [Quest], [Quest_Type], [Frist_Answer], [Second_Answer], [Third_Answer], [Forth_Answer], [Correct_Answer]) VALUES (N'0553241520حساب فرق الجهد القياسيRecording 2025-04-22 115055.mp4', N'السؤال 5', N'Text', N'الاجابة 1', N'الاجابة 2', N'الاجابة 3', N'الاجابة 4', N'1')
GO
INSERT [dbo].[Lessons] ([TeacherId], [ChapterTitle], [Title], [Vedio_Url], [Date], [Time], [Am_Pm], [Academy_Year]) VALUES (N'e87abb7b-2996-40b9-a4db-6e6e6b09cf85', N'الكيمياء التحليلية', N'التحليل الكمي', N'0553241520التحليل الكميRecording 2025-04-22 115055.mp4', N'22-04-2025', N'02:42', N'PM', N'الصف الثالث الثانوى')
INSERT [dbo].[Lessons] ([TeacherId], [ChapterTitle], [Title], [Vedio_Url], [Date], [Time], [Am_Pm], [Academy_Year]) VALUES (N'e87abb7b-2996-40b9-a4db-6e6e6b09cf85', N'الكيمياء التحليلية', N'التحليل النوعي', N'0553241520التحليل النوعيRecording 2025-04-22 115055.mp4', N'22-04-2025', N'02:44', N'PM', N'الصف الثالث الثانوى')
INSERT [dbo].[Lessons] ([TeacherId], [ChapterTitle], [Title], [Vedio_Url], [Date], [Time], [Am_Pm], [Academy_Year]) VALUES (N'e87abb7b-2996-40b9-a4db-6e6e6b09cf85', N'الكيمياء العضوية', N'الألكانات', N'0553241520الألكاناتRecording 2025-04-22 115055.mp4', N'22-04-2025', N'02:16', N'PM', N'الصف الثالث الثانوى')
INSERT [dbo].[Lessons] ([TeacherId], [ChapterTitle], [Title], [Vedio_Url], [Date], [Time], [Am_Pm], [Academy_Year]) VALUES (N'e87abb7b-2996-40b9-a4db-6e6e6b09cf85', N'الكيمياء العضوية', N'الألكاينات', N'0553241520الألكايناتRecording 2025-04-22 115055.mp4', N'22-04-2025', N'02:27', N'PM', N'الصف الثالث الثانوى')
INSERT [dbo].[Lessons] ([TeacherId], [ChapterTitle], [Title], [Vedio_Url], [Date], [Time], [Am_Pm], [Academy_Year]) VALUES (N'e87abb7b-2996-40b9-a4db-6e6e6b09cf85', N'الكيمياء العضوية', N'الألكينات', N'0553241520الألكيناتRecording 2025-04-22 115055.mp4', N'22-04-2025', N'02:24', N'PM', N'الصف الثالث الثانوى')
INSERT [dbo].[Lessons] ([TeacherId], [ChapterTitle], [Title], [Vedio_Url], [Date], [Time], [Am_Pm], [Academy_Year]) VALUES (N'e87abb7b-2996-40b9-a4db-6e6e6b09cf85', N'الكيمياء العضوية', N'البنزين العطري', N'0553241520البنزين العطريRecording 2025-04-22 115055.mp4', N'22-04-2025', N'02:29', N'PM', N'الصف الثالث الثانوى')
INSERT [dbo].[Lessons] ([TeacherId], [ChapterTitle], [Title], [Vedio_Url], [Date], [Time], [Am_Pm], [Academy_Year]) VALUES (N'e87abb7b-2996-40b9-a4db-6e6e6b09cf85', N'الكيمياء الكهربائية', N'الخلايا الجلفانية و الالكتروليتية', N'0553241520الخلايا الجلفانية و الالكتروليتيةRecording 2025-04-22 115055.mp4', N'22-04-2025', N'02:32', N'PM', N'الصف الثالث الثانوى')
INSERT [dbo].[Lessons] ([TeacherId], [ChapterTitle], [Title], [Vedio_Url], [Date], [Time], [Am_Pm], [Academy_Year]) VALUES (N'e87abb7b-2996-40b9-a4db-6e6e6b09cf85', N'الكيمياء الكهربائية', N'المعادلات النصف خلوية', N'0553241520المعادلات النصف خلويةRecording 2025-04-22 115055.mp4', N'22-04-2025', N'02:34', N'PM', N'الصف الثالث الثانوى')
INSERT [dbo].[Lessons] ([TeacherId], [ChapterTitle], [Title], [Vedio_Url], [Date], [Time], [Am_Pm], [Academy_Year]) VALUES (N'e87abb7b-2996-40b9-a4db-6e6e6b09cf85', N'الكيمياء الكهربائية', N'تآكل المعادن', N'0553241520تآكل المعادنRecording 2025-04-22 115055.mp4', N'22-04-2025', N'02:40', N'PM', N'الصف الثالث الثانوى')
INSERT [dbo].[Lessons] ([TeacherId], [ChapterTitle], [Title], [Vedio_Url], [Date], [Time], [Am_Pm], [Academy_Year]) VALUES (N'e87abb7b-2996-40b9-a4db-6e6e6b09cf85', N'الكيمياء الكهربائية', N'حساب فرق الجهد القياسي', N'0553241520حساب فرق الجهد القياسيRecording 2025-04-22 115055.mp4', N'22-04-2025', N'02:38', N'PM', N'الصف الثالث الثانوى')
GO
INSERT [dbo].[Students] ([Id], [Name], [Phone], [Grade], [Department], [SecondLang], [Par_Phone]) VALUES (N'2393fd65-962f-431a-a8fd-1b94381ac54b', N'يوسف إبراهيم', N'0551514721', N'الصف الثاني الثانوى', N'أدبي', N'اللغة الفرنسية', N'0551514766')
INSERT [dbo].[Students] ([Id], [Name], [Phone], [Grade], [Department], [SecondLang], [Par_Phone]) VALUES (N'2ea787ab-5100-4dd5-ba82-f8910150f55c', N'يوسف ابراهيم', N'0551514732', N'الصف الثالث الثانوى', N'علمي علوم', N'اللغة الفرنسية', N'0551514766')
INSERT [dbo].[Students] ([Id], [Name], [Phone], [Grade], [Department], [SecondLang], [Par_Phone]) VALUES (N'5768061c-4a30-4154-9cd7-d8cd5c197558', N'يوسف ابراهيم', N'0551514731', N'الصف الثالث الثانوى', N'أدبي', N'اللغة الفرنسية', N'0551514766')
INSERT [dbo].[Students] ([Id], [Name], [Phone], [Grade], [Department], [SecondLang], [Par_Phone]) VALUES (N'c48468ff-73c3-4675-a17a-137549fc053a', N'يوسف إبراهيم', N'0551514722', N'الصف الثاني الثانوى', N'علمي', N'اللغة الفرنسية', N'0551514766')
INSERT [dbo].[Students] ([Id], [Name], [Phone], [Grade], [Department], [SecondLang], [Par_Phone]) VALUES (N'de0a869f-3515-4648-9b07-951a177b686b', N'يوسف ابراهيم', N'0551514733', N'الصف الثالث الثانوى', N'علمي رياضيات', N'اللغة الفرنسية', N'0551514766')
INSERT [dbo].[Students] ([Id], [Name], [Phone], [Grade], [Department], [SecondLang], [Par_Phone]) VALUES (N'e827d91d-dbd4-4e27-9070-07ee9a4bd2cc', N'يوسف إبراهيم', N'0551514711', N'الصف الأول الثانوى', N'عام', N'اللغة الفرنسية', N'0551514766')
GO
SET IDENTITY_INSERT [dbo].[Subjects] ON 

INSERT [dbo].[Subjects] ([Numbre], [Grade], [Department], [Name], [ImageUrl]) VALUES (2, N'الصف الأول الثانوى', N'عام', N'اللغة العربية', N'Arabic.png')
INSERT [dbo].[Subjects] ([Numbre], [Grade], [Department], [Name], [ImageUrl]) VALUES (3, N'الصف الأول الثانوى', N'عام', N'اللغة الانجليزية', N'English.png')
INSERT [dbo].[Subjects] ([Numbre], [Grade], [Department], [Name], [ImageUrl]) VALUES (4, N'الصف الأول الثانوى', N'عام', N'اللغة الثانية', N'-')
INSERT [dbo].[Subjects] ([Numbre], [Grade], [Department], [Name], [ImageUrl]) VALUES (5, N'الصف الأول الثانوى', N'عام', N'الرياضيات', N'Math.png')
INSERT [dbo].[Subjects] ([Numbre], [Grade], [Department], [Name], [ImageUrl]) VALUES (6, N'الصف الأول الثانوى', N'عام', N'الأحياء', N'Bio.png')
INSERT [dbo].[Subjects] ([Numbre], [Grade], [Department], [Name], [ImageUrl]) VALUES (7, N'الصف الأول الثانوى', N'عام', N'الفيزياء', N'physics.png')
INSERT [dbo].[Subjects] ([Numbre], [Grade], [Department], [Name], [ImageUrl]) VALUES (8, N'الصف الأول الثانوى', N'عام', N'الكيمياء', N'chimi.png')
INSERT [dbo].[Subjects] ([Numbre], [Grade], [Department], [Name], [ImageUrl]) VALUES (9, N'الصف الأول الثانوى', N'عام', N'الجغرافيا', N'maps.png')
INSERT [dbo].[Subjects] ([Numbre], [Grade], [Department], [Name], [ImageUrl]) VALUES (10, N'الصف الأول الثانوى', N'عام', N'التاريخ', N'History.png')
INSERT [dbo].[Subjects] ([Numbre], [Grade], [Department], [Name], [ImageUrl]) VALUES (11, N'الصف الأول الثانوى', N'عام', N'الفلسفة و المنطق', N'Philo.png')
INSERT [dbo].[Subjects] ([Numbre], [Grade], [Department], [Name], [ImageUrl]) VALUES (13, N'الصف الثاني الثانوى', N'علمي', N'اللغة العربية', N'Arabic.png')
INSERT [dbo].[Subjects] ([Numbre], [Grade], [Department], [Name], [ImageUrl]) VALUES (14, N'الصف الثاني الثانوى', N'علمي', N'اللغة الانجليزية', N'English.png')
INSERT [dbo].[Subjects] ([Numbre], [Grade], [Department], [Name], [ImageUrl]) VALUES (15, N'الصف الثاني الثانوى', N'علمي', N'اللغة الثانية', N'-')
INSERT [dbo].[Subjects] ([Numbre], [Grade], [Department], [Name], [ImageUrl]) VALUES (16, N'الصف الثاني الثانوى', N'علمي', N'الرياضيات', N'Math.png')
INSERT [dbo].[Subjects] ([Numbre], [Grade], [Department], [Name], [ImageUrl]) VALUES (17, N'الصف الثاني الثانوى', N'علمي', N'الفيزياء', N'physics.png')
INSERT [dbo].[Subjects] ([Numbre], [Grade], [Department], [Name], [ImageUrl]) VALUES (18, N'الصف الثاني الثانوى', N'علمي', N'الكيمياء', N'chimi.png')
INSERT [dbo].[Subjects] ([Numbre], [Grade], [Department], [Name], [ImageUrl]) VALUES (19, N'الصف الثاني الثانوى', N'علمي', N'الأحياء', N'Bio.png')
INSERT [dbo].[Subjects] ([Numbre], [Grade], [Department], [Name], [ImageUrl]) VALUES (20, N'الصف الثاني الثانوى', N'أدبي', N'اللغة العربية', N'Arabic.png')
INSERT [dbo].[Subjects] ([Numbre], [Grade], [Department], [Name], [ImageUrl]) VALUES (21, N'الصف الثاني الثانوى', N'أدبي', N'اللغة الانجليزية', N'English.png')
INSERT [dbo].[Subjects] ([Numbre], [Grade], [Department], [Name], [ImageUrl]) VALUES (22, N'الصف الثاني الثانوى', N'أدبي', N'اللغة الثانية', N'-')
INSERT [dbo].[Subjects] ([Numbre], [Grade], [Department], [Name], [ImageUrl]) VALUES (23, N'الصف الثاني الثانوى', N'أدبي', N'التاريخ', N'History.png')
INSERT [dbo].[Subjects] ([Numbre], [Grade], [Department], [Name], [ImageUrl]) VALUES (24, N'الصف الثاني الثانوى', N'أدبي', N'الجغرافيا', N'maps.png')
INSERT [dbo].[Subjects] ([Numbre], [Grade], [Department], [Name], [ImageUrl]) VALUES (25, N'الصف الثاني الثانوى', N'أدبي', N'الفلسفة و المنطق', N'Philo.png')
INSERT [dbo].[Subjects] ([Numbre], [Grade], [Department], [Name], [ImageUrl]) VALUES (26, N'الصف الثاني الثانوى', N'أدبي', N'علم النفس و الاجتماع', N'Adabi2.png')
INSERT [dbo].[Subjects] ([Numbre], [Grade], [Department], [Name], [ImageUrl]) VALUES (27, N'الصف الثاني الثانوى', N'أدبي', N'الرياضيات', N'Math.png')
INSERT [dbo].[Subjects] ([Numbre], [Grade], [Department], [Name], [ImageUrl]) VALUES (28, N'الصف الثالث الثانوى', N'علمي علوم', N'اللغة العربية', N'Arabic.png')
INSERT [dbo].[Subjects] ([Numbre], [Grade], [Department], [Name], [ImageUrl]) VALUES (29, N'الصف الثالث الثانوى', N'علمي علوم', N'اللغة الانجليزية', N'English.png')
INSERT [dbo].[Subjects] ([Numbre], [Grade], [Department], [Name], [ImageUrl]) VALUES (30, N'الصف الثالث الثانوى', N'علمي علوم', N'اللغة الثانية', N'-')
INSERT [dbo].[Subjects] ([Numbre], [Grade], [Department], [Name], [ImageUrl]) VALUES (31, N'الصف الثالث الثانوى', N'علمي علوم', N'الأحياء', N'Bio.png')
INSERT [dbo].[Subjects] ([Numbre], [Grade], [Department], [Name], [ImageUrl]) VALUES (32, N'الصف الثالث الثانوى', N'علمي علوم', N'الكيمياء', N'chimi.png')
INSERT [dbo].[Subjects] ([Numbre], [Grade], [Department], [Name], [ImageUrl]) VALUES (33, N'الصف الثالث الثانوى', N'علمي علوم', N'الفيزياء', N'physics.png')
INSERT [dbo].[Subjects] ([Numbre], [Grade], [Department], [Name], [ImageUrl]) VALUES (35, N'الصف الثالث الثانوى', N'علمي علوم', N'الجيولوجيا', N'Giolo.png')
INSERT [dbo].[Subjects] ([Numbre], [Grade], [Department], [Name], [ImageUrl]) VALUES (36, N'الصف الثالث الثانوى', N'علمي رياضيات', N'اللغة العربية', N'Arabic.png')
INSERT [dbo].[Subjects] ([Numbre], [Grade], [Department], [Name], [ImageUrl]) VALUES (37, N'الصف الثالث الثانوى', N'علمي رياضيات', N'اللغة الانجليزية', N'English.png')
INSERT [dbo].[Subjects] ([Numbre], [Grade], [Department], [Name], [ImageUrl]) VALUES (38, N'الصف الثالث الثانوى', N'علمي رياضيات', N'اللغة الثانية', N'-')
INSERT [dbo].[Subjects] ([Numbre], [Grade], [Department], [Name], [ImageUrl]) VALUES (39, N'الصف الثالث الثانوى', N'علمي رياضيات', N'رياضيات', N'Math.png')
INSERT [dbo].[Subjects] ([Numbre], [Grade], [Department], [Name], [ImageUrl]) VALUES (40, N'الصف الثالث الثانوى', N'علمي رياضيات', N'فيزياء', N'physics.png')
INSERT [dbo].[Subjects] ([Numbre], [Grade], [Department], [Name], [ImageUrl]) VALUES (41, N'الصف الثالث الثانوى', N'علمي رياضيات', N'كيمياء', N'chimi.png')
INSERT [dbo].[Subjects] ([Numbre], [Grade], [Department], [Name], [ImageUrl]) VALUES (42, N'الصف الثالث الثانوى', N'أدبي', N'اللغة العربية', N'Arabic.png')
INSERT [dbo].[Subjects] ([Numbre], [Grade], [Department], [Name], [ImageUrl]) VALUES (43, N'الصف الثالث الثانوى', N'أدبي', N'اللغة الانجليزية', N'English.png')
INSERT [dbo].[Subjects] ([Numbre], [Grade], [Department], [Name], [ImageUrl]) VALUES (44, N'الصف الثالث الثانوى', N'أدبي', N'اللغة الثانية', N'-')
INSERT [dbo].[Subjects] ([Numbre], [Grade], [Department], [Name], [ImageUrl]) VALUES (45, N'الصف الثالث الثانوى', N'أدبي', N'التاريخ', N'History.png')
INSERT [dbo].[Subjects] ([Numbre], [Grade], [Department], [Name], [ImageUrl]) VALUES (46, N'الصف الثالث الثانوى', N'أدبي', N'الجغرافيا', N'maps.png')
INSERT [dbo].[Subjects] ([Numbre], [Grade], [Department], [Name], [ImageUrl]) VALUES (47, N'الصف الثالث الثانوى', N'أدبي', N'الفلسفة و المنطق', N'Philo.png')
INSERT [dbo].[Subjects] ([Numbre], [Grade], [Department], [Name], [ImageUrl]) VALUES (48, N'الصف الثالث الثانوى', N'أدبي', N'علم النفس و الاجتماع', N'Adabi2.png')
SET IDENTITY_INSERT [dbo].[Subjects] OFF
GO
INSERT [dbo].[Teachers] ([Id], [Name], [Subject], [Phone], [First], [Second], [Third], [Image_Url]) VALUES (N'2000874b-0597-49a2-9959-d0ebf2953d39', N'ياسر أمير', N'جيـولـوجيـا', N'0595900874', 1, 1, 1, N'059590087411.jpg')
INSERT [dbo].[Teachers] ([Id], [Name], [Subject], [Phone], [First], [Second], [Third], [Image_Url]) VALUES (N'33ee23ac-b136-40c9-9776-01adb3cc8433', N'احمد سمير', N'التاريخ', N'0543902020', 1, 1, 1, N'05439020209.jpg')
INSERT [dbo].[Teachers] ([Id], [Name], [Subject], [Phone], [First], [Second], [Third], [Image_Url]) VALUES (N'37c97fa6-f97d-44a6-8dea-327eff3174b8', N'عنود أحمد', N'اللغة العربية', N'0578900524', 1, 1, 1, N'057890052410.jpg')
INSERT [dbo].[Teachers] ([Id], [Name], [Subject], [Phone], [First], [Second], [Third], [Image_Url]) VALUES (N'75298497-e9f5-47e9-9afe-0cee28f6fcd7', N'مريم أبو اليزيد', N'اللغة الفرنسية', N'0551528007', 1, 1, 1, N'05515280072.jpg')
INSERT [dbo].[Teachers] ([Id], [Name], [Subject], [Phone], [First], [Second], [Third], [Image_Url]) VALUES (N'7532ed3a-f0b1-46a5-a5d6-e36bdbfa9222', N'ياسر عيد', N'اللغة الانجليزية', N'0589666800', 1, 1, 1, N'05896668004.jpg')
INSERT [dbo].[Teachers] ([Id], [Name], [Subject], [Phone], [First], [Second], [Third], [Image_Url]) VALUES (N'891cf7c4-47be-49ef-af4c-057ce1cd443f', N'محمود العوضي', N'اللغة العربية', N'0558237410', 1, 1, 1, N'0558237410image-1.jpg')
INSERT [dbo].[Teachers] ([Id], [Name], [Subject], [Phone], [First], [Second], [Third], [Image_Url]) VALUES (N'ad4b5462-0063-4aec-a045-61c6f1b56206', N'وفاء العيسوى', N'الفيزياء', N'0583300741', 1, 1, 1, N'05833007416.jpg')
INSERT [dbo].[Teachers] ([Id], [Name], [Subject], [Phone], [First], [Second], [Third], [Image_Url]) VALUES (N'c36d3dbf-2818-400e-b153-715bfb8e1adb', N'وائل محمد', N'علم النفس و الاجتماع', N'0502435786', 1, 1, 1, N'050243578611.jpg')
INSERT [dbo].[Teachers] ([Id], [Name], [Subject], [Phone], [First], [Second], [Third], [Image_Url]) VALUES (N'd23a6e6f-d191-48d2-b99d-723419a6226c', N'حنان نصار', N'رياضيات', N'0588200465', 1, 1, 1, N'05882004653.jpg')
INSERT [dbo].[Teachers] ([Id], [Name], [Subject], [Phone], [First], [Second], [Third], [Image_Url]) VALUES (N'e87abb7b-2996-40b9-a4db-6e6e6b09cf85', N'محمد عبد السميع', N'الكيمياء', N'0553241520', 1, 1, 1, N'05532415205.jpg')
GO
ALTER TABLE [dbo].[ExamQuestions] ADD  DEFAULT (N'') FOR [Frist_Answer]
GO
ALTER TABLE [dbo].[ExamQuestions] ADD  DEFAULT (N'') FOR [Second_Answer]
GO
ALTER TABLE [dbo].[ExamQuestions] ADD  DEFAULT (N'') FOR [Third_Answer]
GO
ALTER TABLE [dbo].[ExamQuestions] ADD  DEFAULT (N'') FOR [Forth_Answer]
GO
ALTER TABLE [dbo].[LessonQuestions] ADD  DEFAULT (N'') FOR [Frist_Answer]
GO
ALTER TABLE [dbo].[LessonQuestions] ADD  DEFAULT (N'') FOR [Second_Answer]
GO
ALTER TABLE [dbo].[LessonQuestions] ADD  DEFAULT (N'') FOR [Third_Answer]
GO
ALTER TABLE [dbo].[LessonQuestions] ADD  DEFAULT (N'') FOR [Forth_Answer]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_Teachers_TeacherId] FOREIGN KEY([TeacherId])
REFERENCES [dbo].[Teachers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_Teachers_TeacherId]
GO
ALTER TABLE [dbo].[Chapters]  WITH CHECK ADD  CONSTRAINT [FK_Chapters_Teachers_TeacherId] FOREIGN KEY([TeacherId])
REFERENCES [dbo].[Teachers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Chapters] CHECK CONSTRAINT [FK_Chapters_Teachers_TeacherId]
GO
ALTER TABLE [dbo].[Enrollments]  WITH CHECK ADD  CONSTRAINT [FK_Enrollments_Students_StudentId] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Students] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Enrollments] CHECK CONSTRAINT [FK_Enrollments_Students_StudentId]
GO
ALTER TABLE [dbo].[Enrollments]  WITH CHECK ADD  CONSTRAINT [FK_Enrollments_Teachers_TeacherId] FOREIGN KEY([TeacherId])
REFERENCES [dbo].[Teachers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Enrollments] CHECK CONSTRAINT [FK_Enrollments_Teachers_TeacherId]
GO
ALTER TABLE [dbo].[ExamResults]  WITH CHECK ADD  CONSTRAINT [FK_ExamResults_Students_StudentId] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Students] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ExamResults] CHECK CONSTRAINT [FK_ExamResults_Students_StudentId]
GO
ALTER TABLE [dbo].[ExamResults]  WITH CHECK ADD  CONSTRAINT [FK_ExamResults_Teachers_TeacherId] FOREIGN KEY([TeacherId])
REFERENCES [dbo].[Teachers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ExamResults] CHECK CONSTRAINT [FK_ExamResults_Teachers_TeacherId]
GO
ALTER TABLE [dbo].[Exams]  WITH CHECK ADD  CONSTRAINT [FK_Exams_Teachers_TeacherId] FOREIGN KEY([TeacherId])
REFERENCES [dbo].[Teachers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Exams] CHECK CONSTRAINT [FK_Exams_Teachers_TeacherId]
GO
ALTER TABLE [dbo].[LTestResults]  WITH CHECK ADD  CONSTRAINT [FK_LTestResults_Students_StudentId] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Students] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LTestResults] CHECK CONSTRAINT [FK_LTestResults_Students_StudentId]
GO
