USE [D:\GITREPOSITORY\WARRIORREP\HORNETS 2.0\TRAINING\HORNETSTRAINING\TOCI.MVCEXAMPLE\APP_DATA\TEAMLEASINGDATABASE.MDF]
GO
/****** Object:  Table [dbo].[accbankaccounts]    Script Date: 2016-10-24 10:58:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[accbankaccounts](
	[idAccBankAccounts] [int] IDENTITY(1,1) NOT NULL,
	[accounts_idAccounts] [int] NOT NULL,
	[bank_name] [nvarchar](255) NULL,
	[iban] [int] NULL,
	[control_number] [int] NULL,
	[accountnumber] [nvarchar](45) NULL,
	[accountadress_id] [int] NULL,
 CONSTRAINT [PK_accbankaccounts_idAccBankAccounts] PRIMARY KEY CLUSTERED 
(
	[idAccBankAccounts] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[account]    Script Date: 2016-10-24 10:58:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[account](
	[id_account] [int] IDENTITY(1,1) NOT NULL,
	[login] [nvarchar](25) NULL,
	[password] [nvarchar](64) NULL,
	[role] [nvarchar](255) NULL,
	[firstName] [nvarchar](255) NULL,
	[lastName] [nvarchar](255) NULL,
	[location] [nvarchar](255) NULL,
	[email] [nvarchar](255) NULL,
	[is_active] [smallint] NULL,
	[is_enabled] [smallint] NULL,
	[country] [nvarchar](45) NULL,
	[latitude] [nvarchar](255) NULL,
	[longitude] [nvarchar](255) NULL,
	[register_date] [varchar](8000) NULL,
	[email_hash] [nvarchar](100) NULL,
	[account_token] [nvarchar](100) NULL,
 CONSTRAINT [PK_account_id_account] PRIMARY KEY CLUSTERED 
(
	[id_account] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[accountadresses]    Script Date: 2016-10-24 10:58:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[accountadresses](
	[idAccountAdresses] [int] IDENTITY(1,1) NOT NULL,
	[account_idaccount] [int] NOT NULL,
	[phone] [nvarchar](45) NULL,
	[street] [nvarchar](255) NULL,
	[numbp1] [nvarchar](45) NULL,
	[numbp2] [nvarchar](45) NULL,
	[town] [nvarchar](100) NULL,
	[is_main_adress] [smallint] NOT NULL,
 CONSTRAINT [PK_accountadresses_idAccountAdresses] PRIMARY KEY CLUSTERED 
(
	[idAccountAdresses] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[accpayments]    Script Date: 2016-10-24 10:58:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[accpayments](
	[idAccPayments] [int] NOT NULL,
	[account_id_account] [int] NULL,
	[project_id_project] [int] NULL,
	[AccPaymentscol] [nvarchar](45) NULL,
 CONSTRAINT [PK_accpayments_idAccPayments] PRIMARY KEY CLUSTERED 
(
	[idAccPayments] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[client]    Script Date: 2016-10-24 10:58:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[client](
	[idClient] [int] IDENTITY(1,1) NOT NULL,
	[id_account] [int] NULL,
 CONSTRAINT [PK_client_idClient] PRIMARY KEY CLUSTERED 
(
	[idClient] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[clientsearch]    Script Date: 2016-10-24 10:58:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clientsearch](
	[idClientSearch] [int] IDENTITY(1,1) NOT NULL,
	[Account_idAccount] [int] NOT NULL,
	[search_phrase] [nvarchar](max) NULL,
	[search_date] [datetime2](0) NULL,
 CONSTRAINT [PK_clientsearch_idClientSearch] PRIMARY KEY CLUSTERED 
(
	[idClientSearch] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[contact]    Script Date: 2016-10-24 10:58:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[contact](
	[id_contact] [int] IDENTITY(1,1) NOT NULL,
	[message] [nvarchar](max) NULL,
	[topic] [nvarchar](255) NULL,
	[phone_number] [nvarchar](45) NULL,
	[email] [nvarchar](255) NULL,
 CONSTRAINT [PK_contact_id_contact] PRIMARY KEY CLUSTERED 
(
	[id_contact] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[course]    Script Date: 2016-10-24 10:58:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[course](
	[idCourse] [int] IDENTITY(1,1) NOT NULL,
	[technology_id_promotor] [int] NOT NULL,
	[courses_idCourses] [int] NOT NULL,
	[topic] [nvarchar](255) NULL,
	[agenda] [nvarchar](max) NULL,
	[start_date] [date] NULL,
	[end_date] [date] NULL,
	[level] [int] NULL,
	[attachments] [nvarchar](255) NULL,
 CONSTRAINT [PK_course_idCourse] PRIMARY KEY CLUSTERED 
(
	[idCourse] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[courses]    Script Date: 2016-10-24 10:58:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[courses](
	[idCourses] [int] IDENTITY(1,1) NOT NULL,
	[course_main_name] [nvarchar](255) NULL,
 CONSTRAINT [PK_courses_idCourses] PRIMARY KEY CLUSTERED 
(
	[idCourses] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[coursesgroups]    Script Date: 2016-10-24 10:58:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[coursesgroups](
	[id_courses_group] [int] IDENTITY(1,1) NOT NULL,
	[Course_idCourse] [int] NOT NULL,
	[studygroups_group_number] [int] NOT NULL,
 CONSTRAINT [PK_coursesgroups_id_courses_group] PRIMARY KEY CLUSTERED 
(
	[id_courses_group] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[devavailabilitydetailed]    Script Date: 2016-10-24 10:58:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[devavailabilitydetailed](
	[idDevAvailability] [int] IDENTITY(1,1) NOT NULL,
	[Developer_idDeveloper] [int] NOT NULL,
	[LinkToCalendar] [nvarchar](255) NULL,
 CONSTRAINT [PK_devavailabilitydetailed_idDevAvailability] PRIMARY KEY CLUSTERED 
(
	[idDevAvailability] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[developer]    Script Date: 2016-10-24 10:58:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[developer](
	[id_developer] [int] IDENTITY(1,1) NOT NULL,
	[Account_idAccount] [int] NOT NULL,
	[experience_from] [varchar](8000) NULL,
	[per_hour_cost] [nvarchar](45) NULL,
	[week_availability] [nvarchar](max) NULL,
	[whoiam] [nvarchar](max) NULL,
	[isSuspendedForJobs] [smallint] NOT NULL,
 CONSTRAINT [PK_developer_id_developer] PRIMARY KEY CLUSTERED 
(
	[id_developer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[dictionary]    Script Date: 2016-10-24 10:58:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dictionary](
	[idDictionary] [int] IDENTITY(1,1) NOT NULL,
	[group] [int] NULL,
	[entity] [int] NULL,
	[smallEntity] [int] NULL,
	[display] [nvarchar](255) NULL,
	[isActive] [smallint] NULL,
	[smallEntityOrder] [int] NULL,
	[is_in_dropdown_list] [smallint] NULL,
	[access_level] [int] NULL,
 CONSTRAINT [PK_dictionary_idDictionary] PRIMARY KEY CLUSTERED 
(
	[idDictionary] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[groupscodenames]    Script Date: 2016-10-24 10:58:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[groupscodenames](
	[idGroupsCodenames] [int] IDENTITY(1,1) NOT NULL,
	[cd_name] [nvarchar](255) NULL,
 CONSTRAINT [PK_groupscodenames_idGroupsCodenames] PRIMARY KEY CLUSTERED 
(
	[idGroupsCodenames] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[lessons]    Script Date: 2016-10-24 10:58:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lessons](
	[id_lessons] [int] NOT NULL,
	[courses_id_courses] [int] NOT NULL,
	[lesson_enumeration] [int] NOT NULL,
	[topic] [nvarchar](255) NULL,
	[lesson_materials] [nvarchar](max) NULL,
 CONSTRAINT [PK_lessons_id_lessons] PRIMARY KEY CLUSTERED 
(
	[id_lessons] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[lessonsdetails]    Script Date: 2016-10-24 10:58:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lessonsdetails](
	[id_lessons_details] [int] IDENTITY(1,1) NOT NULL,
	[lessons_id_lessons] [int] NULL,
	[ld_overview] [nvarchar](max) NULL,
	[ld_topic] [nvarchar](255) NULL,
 CONSTRAINT [PK_lessonsdetails_id_lessons_details] PRIMARY KEY CLUSTERED 
(
	[id_lessons_details] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[phrasetechnology]    Script Date: 2016-10-24 10:58:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[phrasetechnology](
	[search_phrase] [int] IDENTITY(1,1) NOT NULL,
	[technology] [nvarchar](45) NULL,
 CONSTRAINT [PK_phrasetechnology_search_phrase] PRIMARY KEY CLUSTERED 
(
	[search_phrase] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[positions]    Script Date: 2016-10-24 10:58:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[positions](
	[id_positions] [int] IDENTITY(1,1) NOT NULL,
	[pos_name] [nvarchar](45) NULL,
 CONSTRAINT [PK_positions_id_positions] PRIMARY KEY CLUSTERED 
(
	[id_positions] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[post]    Script Date: 2016-10-24 10:58:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[post](
	[idPost] [int] IDENTITY(1,1) NOT NULL,
	[content] [nvarchar](max) NULL,
	[add_date] [varchar](8000) NULL,
	[update_date] [varchar](8000) NULL,
	[post_title] [nvarchar](255) NULL,
	[post_type] [int] NULL,
	[PostOwner] [int] NULL,
 CONSTRAINT [PK_post_idPost] PRIMARY KEY CLUSTERED 
(
	[idPost] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[post_course]    Script Date: 2016-10-24 10:58:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[post_course](
	[idPostCourse] [int] IDENTITY(1,1) NOT NULL,
	[Course_idCourse] [int] NOT NULL,
	[Post_idPost] [int] NOT NULL,
 CONSTRAINT [PK_post_course_idPostCourse] PRIMARY KEY CLUSTERED 
(
	[idPostCourse] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[post_tags]    Script Date: 2016-10-24 10:58:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[post_tags](
	[idpost_tags] [int] IDENTITY(1,1) NOT NULL,
	[post_id] [int] NULL,
	[Post_post_id] [int] NOT NULL,
	[tags_id_tags] [int] NOT NULL,
 CONSTRAINT [PK_post_tags_idpost_tags] PRIMARY KEY CLUSTERED 
(
	[idpost_tags] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[project]    Script Date: 2016-10-24 10:58:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[project](
	[id_project] [int] IDENTITY(1,1) NOT NULL,
	[Account_idAccount] [int] NOT NULL,
	[start_date] [date] NULL,
	[death_line] [date] NULL,
	[end_date] [date] NULL,
	[estimated_hours] [int] NULL,
	[logged_hours] [int] NULL,
	[started_by_account] [int] NULL,
	[projectStatus] [int] NOT NULL,
	[project_leader_dev_id] [int] NOT NULL,
 CONSTRAINT [PK_project_id_project] PRIMARY KEY CLUSTERED 
(
	[id_project] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[projectdata]    Script Date: 2016-10-24 10:58:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[projectdata](
	[idProjectData] [int] IDENTITY(1,1) NOT NULL,
	[Project_ProjectId] [int] NOT NULL,
	[ProjectDataDir] [nvarchar](255) NULL,
 CONSTRAINT [PK_projectdata_idProjectData] PRIMARY KEY CLUSTERED 
(
	[idProjectData] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[projectdeveloper]    Script Date: 2016-10-24 10:58:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[projectdeveloper](
	[idProjectDeveloper] [int] IDENTITY(1,1) NOT NULL,
	[Developer_idDeveloper] [int] NOT NULL,
	[Project_idProject] [int] NOT NULL,
 CONSTRAINT [PK_projectdeveloper_idProjectDeveloper] PRIMARY KEY CLUSTERED 
(
	[idProjectDeveloper] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[projectstage]    Script Date: 2016-10-24 10:58:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[projectstage](
	[idProjectStage] [int] NOT NULL,
	[start_date] [nvarchar](45) NULL,
	[end_date] [nvarchar](45) NULL,
	[death_line] [nvarchar](45) NULL,
	[stage_number] [nvarchar](45) NULL,
	[Project_id] [int] NOT NULL,
 CONSTRAINT [PK_projectstage_idProjectStage] PRIMARY KEY CLUSTERED 
(
	[idProjectStage] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[projecttechnologies]    Script Date: 2016-10-24 10:58:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[projecttechnologies](
	[id_projectTechnologies] [int] IDENTITY(1,1) NOT NULL,
	[Technologies_idTechnologies] [int] NOT NULL,
	[Project_idProject] [int] NOT NULL,
 CONSTRAINT [PK_projecttechnologies_id_projectTechnologies] PRIMARY KEY CLUSTERED 
(
	[id_projectTechnologies] ASC,
	[Technologies_idTechnologies] ASC,
	[Project_idProject] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[projecttype]    Script Date: 2016-10-24 10:58:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[projecttype](
	[idProjectType] [int] NOT NULL,
	[description] [int] NULL,
	[Dictionary_idDictionary] [int] NULL,
 CONSTRAINT [PK_projecttype_idProjectType] PRIMARY KEY CLUSTERED 
(
	[idProjectType] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[promotorcourses]    Script Date: 2016-10-24 10:58:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[promotorcourses](
	[idPromotorCourses] [int] IDENTITY(1,1) NOT NULL,
	[techpromotor_id_tech_promotor] [int] NOT NULL,
	[courses_id_courses] [int] NOT NULL,
 CONSTRAINT [PK_promotorcourses_idPromotorCourses] PRIMARY KEY CLUSTERED 
(
	[idPromotorCourses] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[recruitmenttest]    Script Date: 2016-10-24 10:58:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[recruitmenttest](
	[idRecruitmentTest] [int] IDENTITY(1,1) NOT NULL,
	[Account_idAccount] [int] NOT NULL,
	[api] [nvarchar](max) NULL,
	[test_accepted] [varchar](8000) NULL,
	[test_finished] [varchar](8000) NULL,
	[timeForTest] [varchar](8000) NULL,
	[test_result] [smallint] NULL,
	[test_valid_to_date] [varchar](8000) NULL,
	[user_comment] [nvarchar](max) NULL,
	[feedback] [nvarchar](255) NULL,
	[feedback_accountID] [int] NULL,
 CONSTRAINT [PK_recruitmenttest_idRecruitmentTest] PRIMARY KEY CLUSTERED 
(
	[idRecruitmentTest] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[stages]    Script Date: 2016-10-24 10:58:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stages](
	[idStages] [int] NOT NULL,
	[Project_idProject] [int] NOT NULL,
	[Stage_number] [int] NULL,
	[start_stage_date] [date] NULL,
	[end_stage_date] [date] NULL,
	[Stage_accepted] [smallint] NULL,
	[Stage_leaderDeveloperId] [int] NULL,
	[StageOpis] [nvarchar](45) NULL,
	[StageStatus] [int] NULL,
 CONSTRAINT [PK_stages_idStages] PRIMARY KEY CLUSTERED 
(
	[idStages] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[stageteam]    Script Date: 2016-10-24 10:58:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stageteam](
	[id_stage_team] [int] IDENTITY(1,1) NOT NULL,
	[Stages_idStages] [int] NOT NULL,
	[isStageLeader] [smallint] NULL,
	[Developer_idDeveloper] [int] NOT NULL,
 CONSTRAINT [PK_stageteam_id_stage_team] PRIMARY KEY CLUSTERED 
(
	[id_stage_team] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[studygroups]    Script Date: 2016-10-24 10:58:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[studygroups](
	[id_study_groups] [int] IDENTITY(1,1) NOT NULL,
	[account_idaccount] [int] NOT NULL,
	[codename_id_codename] [int] NOT NULL,
	[group_number] [int] NOT NULL,
 CONSTRAINT [PK_studygroups_id_study_groups] PRIMARY KEY CLUSTERED 
(
	[id_study_groups] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tags]    Script Date: 2016-10-24 10:58:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tags](
	[id_tags] [int] IDENTITY(1,1) NOT NULL,
	[title] [nvarchar](255) NULL,
	[category] [nvarchar](255) NULL,
	[tagscol] [nvarchar](45) NULL,
 CONSTRAINT [PK_tags_id_tags] PRIMARY KEY CLUSTERED 
(
	[id_tags] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[technologies]    Script Date: 2016-10-24 10:58:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[technologies](
	[idTechnologies] [int] IDENTITY(1,1) NOT NULL,
	[tech_name] [nvarchar](255) NULL,
	[is_active] [smallint] NOT NULL,
 CONSTRAINT [PK_technologies_idTechnologies] PRIMARY KEY CLUSTERED 
(
	[idTechnologies] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[technologiesdeveloper]    Script Date: 2016-10-24 10:58:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[technologiesdeveloper](
	[id_technologies_dev] [int] IDENTITY(1,1) NOT NULL,
	[Technologies_idTechnologies] [int] NOT NULL,
	[Developer_idDeveloper] [int] NOT NULL,
	[experience_from] [date] NULL,
	[skill_level] [int] NULL,
	[is_tech_promotor] [smallint] NULL,
	[technology_promotor_approved] [smallint] NULL,
 CONSTRAINT [PK_technologiesdeveloper_id_technologies_dev] PRIMARY KEY CLUSTERED 
(
	[id_technologies_dev] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[technologypromotor]    Script Date: 2016-10-24 10:58:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[technologypromotor](
	[idtechnology_promotor] [int] IDENTITY(1,1) NOT NULL,
	[Account_idAccount] [int] NOT NULL,
	[course_id_courses] [int] NOT NULL,
 CONSTRAINT [PK_technologypromotor_idtechnology_promotor] PRIMARY KEY CLUSTERED 
(
	[idtechnology_promotor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[accbankaccounts] ADD  DEFAULT (NULL) FOR [bank_name]
GO
ALTER TABLE [dbo].[accbankaccounts] ADD  DEFAULT (NULL) FOR [iban]
GO
ALTER TABLE [dbo].[accbankaccounts] ADD  DEFAULT (NULL) FOR [control_number]
GO
ALTER TABLE [dbo].[accbankaccounts] ADD  DEFAULT (NULL) FOR [accountnumber]
GO
ALTER TABLE [dbo].[accbankaccounts] ADD  DEFAULT (NULL) FOR [accountadress_id]
GO
ALTER TABLE [dbo].[account] ADD  DEFAULT (NULL) FOR [login]
GO
ALTER TABLE [dbo].[account] ADD  DEFAULT (NULL) FOR [password]
GO
ALTER TABLE [dbo].[account] ADD  DEFAULT (NULL) FOR [role]
GO
ALTER TABLE [dbo].[account] ADD  DEFAULT (NULL) FOR [firstName]
GO
ALTER TABLE [dbo].[account] ADD  DEFAULT (NULL) FOR [lastName]
GO
ALTER TABLE [dbo].[account] ADD  DEFAULT (NULL) FOR [location]
GO
ALTER TABLE [dbo].[account] ADD  DEFAULT (NULL) FOR [email]
GO
ALTER TABLE [dbo].[account] ADD  DEFAULT (NULL) FOR [is_active]
GO
ALTER TABLE [dbo].[account] ADD  DEFAULT (NULL) FOR [is_enabled]
GO
ALTER TABLE [dbo].[account] ADD  DEFAULT (NULL) FOR [country]
GO
ALTER TABLE [dbo].[account] ADD  DEFAULT (NULL) FOR [latitude]
GO
ALTER TABLE [dbo].[account] ADD  DEFAULT (NULL) FOR [longitude]
GO
ALTER TABLE [dbo].[account] ADD  DEFAULT (NULL) FOR [register_date]
GO
ALTER TABLE [dbo].[account] ADD  DEFAULT (NULL) FOR [email_hash]
GO
ALTER TABLE [dbo].[account] ADD  DEFAULT (NULL) FOR [account_token]
GO
ALTER TABLE [dbo].[accountadresses] ADD  DEFAULT (NULL) FOR [phone]
GO
ALTER TABLE [dbo].[accountadresses] ADD  DEFAULT (NULL) FOR [street]
GO
ALTER TABLE [dbo].[accountadresses] ADD  DEFAULT (NULL) FOR [numbp1]
GO
ALTER TABLE [dbo].[accountadresses] ADD  DEFAULT (NULL) FOR [numbp2]
GO
ALTER TABLE [dbo].[accountadresses] ADD  DEFAULT (NULL) FOR [town]
GO
ALTER TABLE [dbo].[accountadresses] ADD  DEFAULT ((0)) FOR [is_main_adress]
GO
ALTER TABLE [dbo].[accpayments] ADD  DEFAULT (NULL) FOR [account_id_account]
GO
ALTER TABLE [dbo].[accpayments] ADD  DEFAULT (NULL) FOR [project_id_project]
GO
ALTER TABLE [dbo].[accpayments] ADD  DEFAULT (NULL) FOR [AccPaymentscol]
GO
ALTER TABLE [dbo].[client] ADD  DEFAULT (NULL) FOR [id_account]
GO
ALTER TABLE [dbo].[clientsearch] ADD  DEFAULT (NULL) FOR [search_date]
GO
ALTER TABLE [dbo].[contact] ADD  DEFAULT (NULL) FOR [topic]
GO
ALTER TABLE [dbo].[contact] ADD  DEFAULT (NULL) FOR [phone_number]
GO
ALTER TABLE [dbo].[contact] ADD  DEFAULT (NULL) FOR [email]
GO
ALTER TABLE [dbo].[course] ADD  DEFAULT (NULL) FOR [topic]
GO
ALTER TABLE [dbo].[course] ADD  DEFAULT (NULL) FOR [start_date]
GO
ALTER TABLE [dbo].[course] ADD  DEFAULT (NULL) FOR [end_date]
GO
ALTER TABLE [dbo].[course] ADD  DEFAULT (NULL) FOR [level]
GO
ALTER TABLE [dbo].[course] ADD  DEFAULT (NULL) FOR [attachments]
GO
ALTER TABLE [dbo].[courses] ADD  DEFAULT (NULL) FOR [course_main_name]
GO
ALTER TABLE [dbo].[devavailabilitydetailed] ADD  DEFAULT (NULL) FOR [LinkToCalendar]
GO
ALTER TABLE [dbo].[developer] ADD  DEFAULT (NULL) FOR [experience_from]
GO
ALTER TABLE [dbo].[developer] ADD  DEFAULT (NULL) FOR [per_hour_cost]
GO
ALTER TABLE [dbo].[developer] ADD  DEFAULT ((0)) FOR [isSuspendedForJobs]
GO
ALTER TABLE [dbo].[dictionary] ADD  DEFAULT (NULL) FOR [group]
GO
ALTER TABLE [dbo].[dictionary] ADD  DEFAULT (NULL) FOR [entity]
GO
ALTER TABLE [dbo].[dictionary] ADD  DEFAULT (NULL) FOR [smallEntity]
GO
ALTER TABLE [dbo].[dictionary] ADD  DEFAULT (NULL) FOR [display]
GO
ALTER TABLE [dbo].[dictionary] ADD  DEFAULT (NULL) FOR [isActive]
GO
ALTER TABLE [dbo].[dictionary] ADD  DEFAULT (NULL) FOR [smallEntityOrder]
GO
ALTER TABLE [dbo].[dictionary] ADD  DEFAULT (NULL) FOR [is_in_dropdown_list]
GO
ALTER TABLE [dbo].[dictionary] ADD  DEFAULT (NULL) FOR [access_level]
GO
ALTER TABLE [dbo].[groupscodenames] ADD  DEFAULT (NULL) FOR [cd_name]
GO
ALTER TABLE [dbo].[lessons] ADD  DEFAULT (NULL) FOR [topic]
GO
ALTER TABLE [dbo].[lessonsdetails] ADD  DEFAULT (NULL) FOR [lessons_id_lessons]
GO
ALTER TABLE [dbo].[lessonsdetails] ADD  DEFAULT (NULL) FOR [ld_topic]
GO
ALTER TABLE [dbo].[phrasetechnology] ADD  DEFAULT (NULL) FOR [technology]
GO
ALTER TABLE [dbo].[positions] ADD  DEFAULT (NULL) FOR [pos_name]
GO
ALTER TABLE [dbo].[post] ADD  DEFAULT (NULL) FOR [add_date]
GO
ALTER TABLE [dbo].[post] ADD  DEFAULT (NULL) FOR [update_date]
GO
ALTER TABLE [dbo].[post] ADD  DEFAULT (NULL) FOR [post_title]
GO
ALTER TABLE [dbo].[post] ADD  DEFAULT (NULL) FOR [post_type]
GO
ALTER TABLE [dbo].[post] ADD  DEFAULT (NULL) FOR [PostOwner]
GO
ALTER TABLE [dbo].[post_tags] ADD  DEFAULT (NULL) FOR [post_id]
GO
ALTER TABLE [dbo].[project] ADD  DEFAULT (NULL) FOR [start_date]
GO
ALTER TABLE [dbo].[project] ADD  DEFAULT (NULL) FOR [death_line]
GO
ALTER TABLE [dbo].[project] ADD  DEFAULT (NULL) FOR [end_date]
GO
ALTER TABLE [dbo].[project] ADD  DEFAULT (NULL) FOR [estimated_hours]
GO
ALTER TABLE [dbo].[project] ADD  DEFAULT ((0)) FOR [logged_hours]
GO
ALTER TABLE [dbo].[project] ADD  DEFAULT (NULL) FOR [started_by_account]
GO
ALTER TABLE [dbo].[project] ADD  DEFAULT ((0)) FOR [projectStatus]
GO
ALTER TABLE [dbo].[projectdata] ADD  DEFAULT (NULL) FOR [ProjectDataDir]
GO
ALTER TABLE [dbo].[projectstage] ADD  DEFAULT (NULL) FOR [start_date]
GO
ALTER TABLE [dbo].[projectstage] ADD  DEFAULT (NULL) FOR [end_date]
GO
ALTER TABLE [dbo].[projectstage] ADD  DEFAULT (NULL) FOR [death_line]
GO
ALTER TABLE [dbo].[projectstage] ADD  DEFAULT (NULL) FOR [stage_number]
GO
ALTER TABLE [dbo].[projecttype] ADD  DEFAULT (NULL) FOR [description]
GO
ALTER TABLE [dbo].[projecttype] ADD  DEFAULT (NULL) FOR [Dictionary_idDictionary]
GO
ALTER TABLE [dbo].[recruitmenttest] ADD  DEFAULT (NULL) FOR [test_accepted]
GO
ALTER TABLE [dbo].[recruitmenttest] ADD  DEFAULT (NULL) FOR [test_finished]
GO
ALTER TABLE [dbo].[recruitmenttest] ADD  DEFAULT (NULL) FOR [timeForTest]
GO
ALTER TABLE [dbo].[recruitmenttest] ADD  DEFAULT (NULL) FOR [test_result]
GO
ALTER TABLE [dbo].[recruitmenttest] ADD  DEFAULT (NULL) FOR [test_valid_to_date]
GO
ALTER TABLE [dbo].[recruitmenttest] ADD  DEFAULT (NULL) FOR [feedback]
GO
ALTER TABLE [dbo].[recruitmenttest] ADD  DEFAULT (NULL) FOR [feedback_accountID]
GO
ALTER TABLE [dbo].[stages] ADD  DEFAULT (NULL) FOR [Stage_number]
GO
ALTER TABLE [dbo].[stages] ADD  DEFAULT (NULL) FOR [start_stage_date]
GO
ALTER TABLE [dbo].[stages] ADD  DEFAULT (NULL) FOR [end_stage_date]
GO
ALTER TABLE [dbo].[stages] ADD  DEFAULT (NULL) FOR [Stage_accepted]
GO
ALTER TABLE [dbo].[stages] ADD  DEFAULT (NULL) FOR [Stage_leaderDeveloperId]
GO
ALTER TABLE [dbo].[stages] ADD  DEFAULT (NULL) FOR [StageOpis]
GO
ALTER TABLE [dbo].[stages] ADD  DEFAULT ((1)) FOR [StageStatus]
GO
ALTER TABLE [dbo].[stageteam] ADD  DEFAULT ((0)) FOR [isStageLeader]
GO
ALTER TABLE [dbo].[tags] ADD  DEFAULT (NULL) FOR [title]
GO
ALTER TABLE [dbo].[tags] ADD  DEFAULT (NULL) FOR [category]
GO
ALTER TABLE [dbo].[tags] ADD  DEFAULT (NULL) FOR [tagscol]
GO
ALTER TABLE [dbo].[technologies] ADD  DEFAULT (NULL) FOR [tech_name]
GO
ALTER TABLE [dbo].[technologies] ADD  DEFAULT ((1)) FOR [is_active]
GO
ALTER TABLE [dbo].[technologiesdeveloper] ADD  DEFAULT (NULL) FOR [experience_from]
GO
ALTER TABLE [dbo].[technologiesdeveloper] ADD  DEFAULT (NULL) FOR [skill_level]
GO
ALTER TABLE [dbo].[technologiesdeveloper] ADD  DEFAULT (NULL) FOR [is_tech_promotor]
GO
ALTER TABLE [dbo].[technologiesdeveloper] ADD  DEFAULT (NULL) FOR [technology_promotor_approved]
GO
ALTER TABLE [dbo].[accountadresses]  WITH CHECK ADD  CONSTRAINT [accountadresses$fk_accountAdresses__account] FOREIGN KEY([account_idaccount])
REFERENCES [dbo].[account] ([id_account])
GO
ALTER TABLE [dbo].[accountadresses] CHECK CONSTRAINT [accountadresses$fk_accountAdresses__account]
GO
ALTER TABLE [dbo].[client]  WITH CHECK ADD  CONSTRAINT [client$fk_client_on_account] FOREIGN KEY([id_account])
REFERENCES [dbo].[account] ([id_account])
GO
ALTER TABLE [dbo].[client] CHECK CONSTRAINT [client$fk_client_on_account]
GO
ALTER TABLE [dbo].[clientsearch]  WITH CHECK ADD  CONSTRAINT [clientsearch$fk_ClientSearch_Account] FOREIGN KEY([Account_idAccount])
REFERENCES [dbo].[account] ([id_account])
GO
ALTER TABLE [dbo].[clientsearch] CHECK CONSTRAINT [clientsearch$fk_ClientSearch_Account]
GO
ALTER TABLE [dbo].[course]  WITH CHECK ADD  CONSTRAINT [course$fk_course__courses] FOREIGN KEY([courses_idCourses])
REFERENCES [dbo].[courses] ([idCourses])
GO
ALTER TABLE [dbo].[course] CHECK CONSTRAINT [course$fk_course__courses]
GO
ALTER TABLE [dbo].[course]  WITH CHECK ADD  CONSTRAINT [course$fk_course__technology_promotor] FOREIGN KEY([technology_id_promotor])
REFERENCES [dbo].[technologypromotor] ([idtechnology_promotor])
GO
ALTER TABLE [dbo].[course] CHECK CONSTRAINT [course$fk_course__technology_promotor]
GO
ALTER TABLE [dbo].[coursesgroups]  WITH CHECK ADD  CONSTRAINT [coursesgroups$fk_coursesgroup__studygroups] FOREIGN KEY([studygroups_group_number])
REFERENCES [dbo].[studygroups] ([id_study_groups])
GO
ALTER TABLE [dbo].[coursesgroups] CHECK CONSTRAINT [coursesgroups$fk_coursesgroup__studygroups]
GO
ALTER TABLE [dbo].[coursesgroups]  WITH CHECK ADD  CONSTRAINT [coursesgroups$fk_GroupCourse_to_Course] FOREIGN KEY([Course_idCourse])
REFERENCES [dbo].[course] ([idCourse])
GO
ALTER TABLE [dbo].[coursesgroups] CHECK CONSTRAINT [coursesgroups$fk_GroupCourse_to_Course]
GO
ALTER TABLE [dbo].[devavailabilitydetailed]  WITH CHECK ADD  CONSTRAINT [devavailabilitydetailed$fk_DevAvailabilityDetailed_Developer1] FOREIGN KEY([Developer_idDeveloper])
REFERENCES [dbo].[developer] ([id_developer])
GO
ALTER TABLE [dbo].[devavailabilitydetailed] CHECK CONSTRAINT [devavailabilitydetailed$fk_DevAvailabilityDetailed_Developer1]
GO
ALTER TABLE [dbo].[developer]  WITH CHECK ADD  CONSTRAINT [developer$fk_Developer_Account] FOREIGN KEY([Account_idAccount])
REFERENCES [dbo].[account] ([id_account])
GO
ALTER TABLE [dbo].[developer] CHECK CONSTRAINT [developer$fk_Developer_Account]
GO
ALTER TABLE [dbo].[lessons]  WITH CHECK ADD  CONSTRAINT [lessons$fk_subCourses__Courses] FOREIGN KEY([courses_id_courses])
REFERENCES [dbo].[courses] ([idCourses])
GO
ALTER TABLE [dbo].[lessons] CHECK CONSTRAINT [lessons$fk_subCourses__Courses]
GO
ALTER TABLE [dbo].[lessonsdetails]  WITH CHECK ADD  CONSTRAINT [lessonsdetails$fk_lessonsdetails__lessons] FOREIGN KEY([lessons_id_lessons])
REFERENCES [dbo].[lessons] ([id_lessons])
GO
ALTER TABLE [dbo].[lessonsdetails] CHECK CONSTRAINT [lessonsdetails$fk_lessonsdetails__lessons]
GO
ALTER TABLE [dbo].[post]  WITH CHECK ADD  CONSTRAINT [post$fk_post_owner] FOREIGN KEY([PostOwner])
REFERENCES [dbo].[account] ([id_account])
GO
ALTER TABLE [dbo].[post] CHECK CONSTRAINT [post$fk_post_owner]
GO
ALTER TABLE [dbo].[post_course]  WITH CHECK ADD  CONSTRAINT [post_course$fk_post_course_Course] FOREIGN KEY([Course_idCourse])
REFERENCES [dbo].[course] ([idCourse])
GO
ALTER TABLE [dbo].[post_course] CHECK CONSTRAINT [post_course$fk_post_course_Course]
GO
ALTER TABLE [dbo].[post_course]  WITH CHECK ADD  CONSTRAINT [post_course$fk_post_course_Post] FOREIGN KEY([Post_idPost])
REFERENCES [dbo].[post] ([idPost])
GO
ALTER TABLE [dbo].[post_course] CHECK CONSTRAINT [post_course$fk_post_course_Post]
GO
ALTER TABLE [dbo].[post_tags]  WITH CHECK ADD  CONSTRAINT [post_tags$fk_post_tags_Post1] FOREIGN KEY([Post_post_id])
REFERENCES [dbo].[post] ([idPost])
GO
ALTER TABLE [dbo].[post_tags] CHECK CONSTRAINT [post_tags$fk_post_tags_Post1]
GO
ALTER TABLE [dbo].[post_tags]  WITH CHECK ADD  CONSTRAINT [post_tags$fk_post_tags_tags1] FOREIGN KEY([tags_id_tags])
REFERENCES [dbo].[tags] ([id_tags])
GO
ALTER TABLE [dbo].[post_tags] CHECK CONSTRAINT [post_tags$fk_post_tags_tags1]
GO
ALTER TABLE [dbo].[project]  WITH CHECK ADD  CONSTRAINT [project$fk_Project_Account1] FOREIGN KEY([Account_idAccount])
REFERENCES [dbo].[account] ([id_account])
GO
ALTER TABLE [dbo].[project] CHECK CONSTRAINT [project$fk_Project_Account1]
GO
ALTER TABLE [dbo].[projectdata]  WITH CHECK ADD  CONSTRAINT [projectdata$fk_projectdata_project] FOREIGN KEY([Project_ProjectId])
REFERENCES [dbo].[project] ([id_project])
GO
ALTER TABLE [dbo].[projectdata] CHECK CONSTRAINT [projectdata$fk_projectdata_project]
GO
ALTER TABLE [dbo].[projectdeveloper]  WITH CHECK ADD  CONSTRAINT [projectdeveloper$fk_ProjectDeveloper_Developer1] FOREIGN KEY([Developer_idDeveloper])
REFERENCES [dbo].[developer] ([id_developer])
GO
ALTER TABLE [dbo].[projectdeveloper] CHECK CONSTRAINT [projectdeveloper$fk_ProjectDeveloper_Developer1]
GO
ALTER TABLE [dbo].[projectdeveloper]  WITH CHECK ADD  CONSTRAINT [projectdeveloper$fk_ProjectDeveloper_Project] FOREIGN KEY([Project_idProject])
REFERENCES [dbo].[project] ([id_project])
GO
ALTER TABLE [dbo].[projectdeveloper] CHECK CONSTRAINT [projectdeveloper$fk_ProjectDeveloper_Project]
GO
ALTER TABLE [dbo].[projectstage]  WITH CHECK ADD  CONSTRAINT [projectstage$fk_ProjectStage_Project1] FOREIGN KEY([Project_id])
REFERENCES [dbo].[project] ([id_project])
GO
ALTER TABLE [dbo].[projectstage] CHECK CONSTRAINT [projectstage$fk_ProjectStage_Project1]
GO
ALTER TABLE [dbo].[projecttechnologies]  WITH CHECK ADD  CONSTRAINT [projecttechnologies$fk_project] FOREIGN KEY([Project_idProject])
REFERENCES [dbo].[project] ([id_project])
GO
ALTER TABLE [dbo].[projecttechnologies] CHECK CONSTRAINT [projecttechnologies$fk_project]
GO
ALTER TABLE [dbo].[projecttechnologies]  WITH CHECK ADD  CONSTRAINT [projecttechnologies$fk_technologies] FOREIGN KEY([Technologies_idTechnologies])
REFERENCES [dbo].[technologies] ([idTechnologies])
GO
ALTER TABLE [dbo].[projecttechnologies] CHECK CONSTRAINT [projecttechnologies$fk_technologies]
GO
ALTER TABLE [dbo].[promotorcourses]  WITH CHECK ADD  CONSTRAINT [promotorcourses$fk_promotor_courses__techpromotor] FOREIGN KEY([techpromotor_id_tech_promotor])
REFERENCES [dbo].[technologypromotor] ([idtechnology_promotor])
GO
ALTER TABLE [dbo].[promotorcourses] CHECK CONSTRAINT [promotorcourses$fk_promotor_courses__techpromotor]
GO
ALTER TABLE [dbo].[promotorcourses]  WITH CHECK ADD  CONSTRAINT [promotorcourses$fk_promotorcourses_courses] FOREIGN KEY([courses_id_courses])
REFERENCES [dbo].[courses] ([idCourses])
GO
ALTER TABLE [dbo].[promotorcourses] CHECK CONSTRAINT [promotorcourses$fk_promotorcourses_courses]
GO
ALTER TABLE [dbo].[recruitmenttest]  WITH CHECK ADD  CONSTRAINT [recruitmenttest$fk_RecruitmentTest_Account1] FOREIGN KEY([Account_idAccount])
REFERENCES [dbo].[account] ([id_account])
GO
ALTER TABLE [dbo].[recruitmenttest] CHECK CONSTRAINT [recruitmenttest$fk_RecruitmentTest_Account1]
GO
ALTER TABLE [dbo].[stages]  WITH CHECK ADD  CONSTRAINT [stages$fk_Stages_Project1] FOREIGN KEY([Project_idProject])
REFERENCES [dbo].[project] ([id_project])
GO
ALTER TABLE [dbo].[stages] CHECK CONSTRAINT [stages$fk_Stages_Project1]
GO
ALTER TABLE [dbo].[stageteam]  WITH CHECK ADD  CONSTRAINT [stageteam$fk_StagesTeams_Stages] FOREIGN KEY([Stages_idStages])
REFERENCES [dbo].[stages] ([idStages])
GO
ALTER TABLE [dbo].[stageteam] CHECK CONSTRAINT [stageteam$fk_StagesTeams_Stages]
GO
ALTER TABLE [dbo].[stageteam]  WITH CHECK ADD  CONSTRAINT [stageteam$fk_stageteam_developer] FOREIGN KEY([Developer_idDeveloper])
REFERENCES [dbo].[developer] ([id_developer])
GO
ALTER TABLE [dbo].[stageteam] CHECK CONSTRAINT [stageteam$fk_stageteam_developer]
GO
ALTER TABLE [dbo].[studygroups]  WITH CHECK ADD  CONSTRAINT [studygroups$fk_studygroups__account] FOREIGN KEY([account_idaccount])
REFERENCES [dbo].[account] ([id_account])
GO
ALTER TABLE [dbo].[studygroups] CHECK CONSTRAINT [studygroups$fk_studygroups__account]
GO
ALTER TABLE [dbo].[studygroups]  WITH CHECK ADD  CONSTRAINT [studygroups$fk_studygroups_groupscodenames] FOREIGN KEY([codename_id_codename])
REFERENCES [dbo].[groupscodenames] ([idGroupsCodenames])
GO
ALTER TABLE [dbo].[studygroups] CHECK CONSTRAINT [studygroups$fk_studygroups_groupscodenames]
GO
ALTER TABLE [dbo].[technologiesdeveloper]  WITH CHECK ADD  CONSTRAINT [technologiesdeveloper$fk_TechnologiesDeveloper_Developer1] FOREIGN KEY([Developer_idDeveloper])
REFERENCES [dbo].[developer] ([id_developer])
GO
ALTER TABLE [dbo].[technologiesdeveloper] CHECK CONSTRAINT [technologiesdeveloper$fk_TechnologiesDeveloper_Developer1]
GO
ALTER TABLE [dbo].[technologiesdeveloper]  WITH CHECK ADD  CONSTRAINT [technologiesdeveloper$fk_TechnologiesDeveloper_Technologies1] FOREIGN KEY([Technologies_idTechnologies])
REFERENCES [dbo].[technologies] ([idTechnologies])
GO
ALTER TABLE [dbo].[technologiesdeveloper] CHECK CONSTRAINT [technologiesdeveloper$fk_TechnologiesDeveloper_Technologies1]
GO
ALTER TABLE [dbo].[technologypromotor]  WITH CHECK ADD  CONSTRAINT [technologypromotor$fk_Promotor_Account1] FOREIGN KEY([Account_idAccount])
REFERENCES [dbo].[account] ([id_account])
GO
ALTER TABLE [dbo].[technologypromotor] CHECK CONSTRAINT [technologypromotor$fk_Promotor_Account1]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'teamleasing.accbankaccounts' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'accbankaccounts'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'teamleasing.account' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'account'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'teamleasing.accountadresses' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'accountadresses'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'teamleasing.accpayments' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'accpayments'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'teamleasing.client' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'client'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'teamleasing.clientsearch' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'clientsearch'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'teamleasing.contact' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'contact'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'teamleasing.course' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'course'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'teamleasing.courses' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'courses'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'teamleasing.coursesgroups' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'coursesgroups'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'teamleasing.devavailabilitydetailed' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'devavailabilitydetailed'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'teamleasing.developer' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'developer'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'teamleasing.dictionary' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'dictionary'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'teamleasing.groupscodenames' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'groupscodenames'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'teamleasing.lessons' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'lessons'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'teamleasing.lessonsdetails' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'lessonsdetails'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'teamleasing.phrasetechnology' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'phrasetechnology'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'teamleasing.positions' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'positions'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'teamleasing.post' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'post'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'teamleasing.post_course' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'post_course'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'teamleasing.post_tags' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'post_tags'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'teamleasing.project' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'project'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'teamleasing.projectdata' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'projectdata'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'teamleasing.projectdeveloper' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'projectdeveloper'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'teamleasing.projectstage' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'projectstage'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'teamleasing.projecttechnologies' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'projecttechnologies'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'teamleasing.projecttype' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'projecttype'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'teamleasing.promotorcourses' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'promotorcourses'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'teamleasing.recruitmenttest' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'recruitmenttest'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'teamleasing.stages' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'stages'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'teamleasing.stageteam' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'stageteam'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'teamleasing.studygroups' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'studygroups'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'teamleasing.tags' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tags'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'teamleasing.technologies' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'technologies'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'teamleasing.technologiesdeveloper' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'technologiesdeveloper'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_SSMA_SOURCE', @value=N'teamleasing.technologypromotor' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'technologypromotor'
GO
