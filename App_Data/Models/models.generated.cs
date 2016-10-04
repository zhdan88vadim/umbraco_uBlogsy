//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.4.0
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

[assembly: PureLiveAssembly]
[assembly:ModelsBuilderAssembly(PureLive = true, SourceHash = "cad99c183e11a706")]
[assembly:System.Reflection.AssemblyVersion("0.0.0.1")]

namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>[uBlogsy] [Base]</summary>
	[PublishedContentModel("uBlogsyBaseDocType")]
	public partial class UBlogsyBaseDocType : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "uBlogsyBaseDocType";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public UBlogsyBaseDocType(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<UBlogsyBaseDocType, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Invisible Redirect
		///</summary>
		[ImplementPropertyType("umbracoInternalRedirectId")]
		public object UmbracoInternalRedirectId
		{
			get { return this.GetPropertyValue("umbracoInternalRedirectId"); }
		}

		///<summary>
		/// Hide from navigation
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return this.GetPropertyValue<bool>("umbracoNaviHide"); }
		}

		///<summary>
		/// 302 Redirect
		///</summary>
		[ImplementPropertyType("umbracoRedirect")]
		public object UmbracoRedirect
		{
			get { return this.GetPropertyValue("umbracoRedirect"); }
		}

		///<summary>
		/// Url Alias
		///</summary>
		[ImplementPropertyType("umbracoUrlAlias")]
		public string UmbracoUrlAlias
		{
			get { return this.GetPropertyValue<string>("umbracoUrlAlias"); }
		}

		///<summary>
		/// Url Name Change
		///</summary>
		[ImplementPropertyType("umbracoUrlName")]
		public string UmbracoUrlName
		{
			get { return this.GetPropertyValue<string>("umbracoUrlName"); }
		}
	}

	/// <summary>[uBlogsy] [Base] Container</summary>
	[PublishedContentModel("uBlogsyBaseContainer")]
	public partial class UBlogsyBaseContainer : UBlogsyBaseDocType
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "uBlogsyBaseContainer";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public UBlogsyBaseContainer(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<UBlogsyBaseContainer, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>[uBlogsy] [Base] Page</summary>
	[PublishedContentModel("uBlogsyBasePage")]
	public partial class UBlogsyBasePage : UBlogsyBaseDocType
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "uBlogsyBasePage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public UBlogsyBasePage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<UBlogsyBasePage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Body
		///</summary>
		[ImplementPropertyType("uBlogsyContentBody")]
		public IHtmlString UBlogsyContentBody
		{
			get { return this.GetPropertyValue<IHtmlString>("uBlogsyContentBody"); }
		}

		///<summary>
		/// Summary
		///</summary>
		[ImplementPropertyType("uBlogsyContentSummary")]
		public string UBlogsyContentSummary
		{
			get { return this.GetPropertyValue<string>("uBlogsyContentSummary"); }
		}

		///<summary>
		/// Title
		///</summary>
		[ImplementPropertyType("uBlogsyContentTitle")]
		public string UBlogsyContentTitle
		{
			get { return this.GetPropertyValue<string>("uBlogsyContentTitle"); }
		}

		///<summary>
		/// Navigation Title
		///</summary>
		[ImplementPropertyType("uBlogsyNavigationTitle")]
		public string UBlogsyNavigationTitle
		{
			get { return this.GetPropertyValue<string>("uBlogsyNavigationTitle"); }
		}

		///<summary>
		/// Description: Used for meta description. When this is empty, an exerpt of the body text of the page is used.
		///</summary>
		[ImplementPropertyType("uBlogsySeoDescription")]
		public string UBlogsySeoDescription
		{
			get { return this.GetPropertyValue<string>("uBlogsySeoDescription"); }
		}

		///<summary>
		/// Keywords: Used for meta keywords. When this is empty, the title of the page is used.
		///</summary>
		[ImplementPropertyType("uBlogsySeoKeywords")]
		public string UBlogsySeoKeywords
		{
			get { return this.GetPropertyValue<string>("uBlogsySeoKeywords"); }
		}

		///<summary>
		/// Seo Title
		///</summary>
		[ImplementPropertyType("uBlogsySeoTitle")]
		public string UBlogsySeoTitle
		{
			get { return this.GetPropertyValue<string>("uBlogsySeoTitle"); }
		}
	}

	/// <summary>[uBlogsy] Author</summary>
	[PublishedContentModel("uBlogsyAuthor")]
	public partial class UBlogsyAuthor : UBlogsyBaseDocType
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "uBlogsyAuthor";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public UBlogsyAuthor(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<UBlogsyAuthor, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Gravatar Email
		///</summary>
		[ImplementPropertyType("uBlogsyAuthorGravatarEmail")]
		public string UBlogsyAuthorGravatarEmail
		{
			get { return this.GetPropertyValue<string>("uBlogsyAuthorGravatarEmail"); }
		}

		///<summary>
		/// Author Name
		///</summary>
		[ImplementPropertyType("uBlogsyAuthorName")]
		public string UBlogsyAuthorName
		{
			get { return this.GetPropertyValue<string>("uBlogsyAuthorName"); }
		}
	}

	/// <summary>[uBlogsy] Category/Label</summary>
	[PublishedContentModel("uBlogsyLabel")]
	public partial class UBlogsyLabel : UBlogsyBaseDocType
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "uBlogsyLabel";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public UBlogsyLabel(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<UBlogsyLabel, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Label Name
		///</summary>
		[ImplementPropertyType("uBlogsyLabelName")]
		public string UBlogsyLabelName
		{
			get { return this.GetPropertyValue<string>("uBlogsyLabelName"); }
		}
	}

	/// <summary>[uBlogsy] Container - Author</summary>
	[PublishedContentModel("uBlogsyContainerAuthor")]
	public partial class UBlogsyContainerAuthor : UBlogsyBaseContainer
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "uBlogsyContainerAuthor";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public UBlogsyContainerAuthor(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<UBlogsyContainerAuthor, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>[uBlogsy] Container - Label</summary>
	[PublishedContentModel("uBlogsyContainerLabel")]
	public partial class UBlogsyContainerLabel : UBlogsyBaseContainer
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "uBlogsyContainerLabel";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public UBlogsyContainerLabel(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<UBlogsyContainerLabel, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>[uBlogsy] Landing</summary>
	[PublishedContentModel("uBlogsyLanding")]
	public partial class UBlogsyLanding : UBlogsyBasePage
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "uBlogsyLanding";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public UBlogsyLanding(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<UBlogsyLanding, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Blog Roll Links: A list of blogs you want to follow. Make sure it's one per line.    e.g   http://feeds.feedburner.com/midcodecrisis  http://feeds.feedburner.com/umbracoblog
		///</summary>
		[ImplementPropertyType("uBlogsyBlogLinks")]
		public string UBlogsyBlogLinks
		{
			get { return this.GetPropertyValue<string>("uBlogsyBlogLinks"); }
		}

		///<summary>
		/// Default Author: This author is used when none are defined in a post.
		///</summary>
		[ImplementPropertyType("uBlogsyGeneralDefaultAuthor")]
		public string UBlogsyGeneralDefaultAuthor
		{
			get { return this.GetPropertyValue<string>("uBlogsyGeneralDefaultAuthor"); }
		}

		///<summary>
		/// Show Social Media Links: Select this to show social media sharing links under each post.
		///</summary>
		[ImplementPropertyType("uBlogsyGeneralShowSocialMedia")]
		public bool UBlogsyGeneralShowSocialMedia
		{
			get { return this.GetPropertyValue<bool>("uBlogsyGeneralShowSocialMedia"); }
		}

		///<summary>
		/// Use Summary On Landing: Select this to use post summaries on the main page, instead of whole posts.  
		///</summary>
		[ImplementPropertyType("uBlogsyGeneralUseSummary")]
		public bool UBlogsyGeneralUseSummary
		{
			get { return this.GetPropertyValue<bool>("uBlogsyGeneralUseSummary"); }
		}

		///<summary>
		/// Use Title As Node Name: Deselect this if you want to have a post title which is different to your post's node name.    eg. If you want your title to be "My title" but you want the post url to be /posts/2011/01/my-cool-title/ instead of /posts/2011/01/my-title/    Selected by default.
		///</summary>
		[ImplementPropertyType("uBlogsyGeneralUseTitleAsNodeName")]
		public bool UBlogsyGeneralUseTitleAsNodeName
		{
			get { return this.GetPropertyValue<bool>("uBlogsyGeneralUseTitleAsNodeName"); }
		}
	}

	/// <summary>[uBlogsy] Page</summary>
	[PublishedContentModel("uBlogsyPage")]
	public partial class UBlogsyPage : UBlogsyBasePage
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "uBlogsyPage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public UBlogsyPage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<UBlogsyPage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>[uBlogsy] Post</summary>
	[PublishedContentModel("uBlogsyPost")]
	public partial class UBlogsyPost : UBlogsyBasePage
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "uBlogsyPost";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public UBlogsyPost(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<UBlogsyPost, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Author: There can be multiple authors separated by ",".
		///</summary>
		[ImplementPropertyType("uBlogsyPostAuthor")]
		public string UBlogsyPostAuthor
		{
			get { return this.GetPropertyValue<string>("uBlogsyPostAuthor"); }
		}

		///<summary>
		/// Post Date
		///</summary>
		[ImplementPropertyType("uBlogsyPostDate")]
		public DateTime UBlogsyPostDate
		{
			get { return this.GetPropertyValue<DateTime>("uBlogsyPostDate"); }
		}

		///<summary>
		/// Disable Comments: Allows you to disable comments to this post. Note that comments that already exist will remain viewable.    If you do not have the comments extension installed, then you can delete this property.  
		///</summary>
		[ImplementPropertyType("uBlogsyPostDisableComments")]
		public bool UBlogsyPostDisableComments
		{
			get { return this.GetPropertyValue<bool>("uBlogsyPostDisableComments"); }
		}

		///<summary>
		/// Main Image
		///</summary>
		[ImplementPropertyType("uBlogsyPostImage")]
		public string UBlogsyPostImage
		{
			get { return this.GetPropertyValue<string>("uBlogsyPostImage"); }
		}

		///<summary>
		/// Categories
		///</summary>
		[ImplementPropertyType("uBlogsyPostLabels")]
		public string UBlogsyPostLabels
		{
			get { return this.GetPropertyValue<string>("uBlogsyPostLabels"); }
		}

		///<summary>
		/// Tags: Remember to click save (or publish)!
		///</summary>
		[ImplementPropertyType("uBlogsyPostTags")]
		public object UBlogsyPostTags
		{
			get { return this.GetPropertyValue("uBlogsyPostTags"); }
		}
	}

	/// <summary>[uBlogsy] RSS</summary>
	[PublishedContentModel("uBlogsyRSS")]
	public partial class UBlogsyRss : UBlogsyBaseDocType
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "uBlogsyRSS";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public UBlogsyRss(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<UBlogsyRss, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Copyright: Copyright information which is shown in your RSS feed.    e.g Mid-code Crisis  
		///</summary>
		[ImplementPropertyType("uBlogsyRssCopyright")]
		public string UBlogsyRssCopyright
		{
			get { return this.GetPropertyValue<string>("uBlogsyRssCopyright"); }
		}

		///<summary>
		/// Description: The description of your RSS feed
		///</summary>
		[ImplementPropertyType("uBlogsyRssDescription")]
		public string UBlogsyRssDescription
		{
			get { return this.GetPropertyValue<string>("uBlogsyRssDescription"); }
		}

		///<summary>
		/// Title: The title which is shown in your RSS feed
		///</summary>
		[ImplementPropertyType("uBlogsyRssTitle")]
		public string UBlogsyRssTitle
		{
			get { return this.GetPropertyValue<string>("uBlogsyRssTitle"); }
		}
	}

	/// <summary>[uBlogsy] Site Root</summary>
	[PublishedContentModel("uBlogsySiteRoot")]
	public partial class UBlogsySiteRoot : UBlogsyBasePage
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "uBlogsySiteRoot";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public UBlogsySiteRoot(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<UBlogsySiteRoot, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>[uDateFoldersy] [Base]</summary>
	[PublishedContentModel("uDateFoldersyBase")]
	public partial class UDateFoldersyBase : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "uDateFoldersyBase";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public UDateFoldersyBase(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<UDateFoldersyBase, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>[uDateFoldersy] Folder - Day</summary>
	[PublishedContentModel("uDateFoldersyFolderDay")]
	public partial class UDateFoldersyFolderDay : UDateFoldersyBase
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "uDateFoldersyFolderDay";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public UDateFoldersyFolderDay(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<UDateFoldersyFolderDay, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>[uDateFoldersy] Folder - Month</summary>
	[PublishedContentModel("uDateFoldersyFolderMonth")]
	public partial class UDateFoldersyFolderMonth : UDateFoldersyBase
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "uDateFoldersyFolderMonth";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public UDateFoldersyFolderMonth(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<UDateFoldersyFolderMonth, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>[uDateFoldersy] Folder - Year</summary>
	[PublishedContentModel("uDateFoldersyFolderYear")]
	public partial class UDateFoldersyFolderYear : UDateFoldersyBase
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "uDateFoldersyFolderYear";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public UDateFoldersyFolderYear(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<UDateFoldersyFolderYear, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>[uTagsy] [Base]</summary>
	[PublishedContentModel("uTagsyBaseDocType")]
	public partial class UTagsyBaseDocType : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "uTagsyBaseDocType";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public UTagsyBaseDocType(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<UTagsyBaseDocType, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>[uTagsy] Tag</summary>
	[PublishedContentModel("uTagsyTag")]
	public partial class UTagsyTag : UTagsyBaseDocType
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "uTagsyTag";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public UTagsyTag(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<UTagsyTag, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Tag Name
		///</summary>
		[ImplementPropertyType("uTagsyTagName")]
		public string UTagsyTagName
		{
			get { return this.GetPropertyValue<string>("uTagsyTagName"); }
		}
	}

	/// <summary>[uTagsy] Tag Container</summary>
	[PublishedContentModel("uTagsyTagContainer")]
	public partial class UTagsyTagContainer : UTagsyBaseDocType
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "uTagsyTagContainer";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public UTagsyTagContainer(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<UTagsyTagContainer, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Folder</summary>
	[PublishedContentModel("Folder")]
	public partial class Folder : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Folder";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Folder(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Folder, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Contents:
		///</summary>
		[ImplementPropertyType("contents")]
		public object Contents
		{
			get { return this.GetPropertyValue("contents"); }
		}
	}

	/// <summary>Image</summary>
	[PublishedContentModel("Image")]
	public partial class Image : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Image";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Image(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Image, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload image
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public Umbraco.Web.Models.ImageCropDataSet UmbracoFile
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("umbracoFile"); }
		}

		///<summary>
		/// Height
		///</summary>
		[ImplementPropertyType("umbracoHeight")]
		public string UmbracoHeight
		{
			get { return this.GetPropertyValue<string>("umbracoHeight"); }
		}

		///<summary>
		/// Width
		///</summary>
		[ImplementPropertyType("umbracoWidth")]
		public string UmbracoWidth
		{
			get { return this.GetPropertyValue<string>("umbracoWidth"); }
		}
	}

	/// <summary>File</summary>
	[PublishedContentModel("File")]
	public partial class File : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "File";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public File(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<File, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload file
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public object UmbracoFile
		{
			get { return this.GetPropertyValue("umbracoFile"); }
		}
	}

	/// <summary>Member</summary>
	[PublishedContentModel("Member")]
	public partial class Member : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Member";
		public new const PublishedItemType ModelItemType = PublishedItemType.Member;
#pragma warning restore 0109

		public Member(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Member, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Is Approved
		///</summary>
		[ImplementPropertyType("umbracoMemberApproved")]
		public bool UmbracoMemberApproved
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberApproved"); }
		}

		///<summary>
		/// Comments
		///</summary>
		[ImplementPropertyType("umbracoMemberComments")]
		public string UmbracoMemberComments
		{
			get { return this.GetPropertyValue<string>("umbracoMemberComments"); }
		}

		///<summary>
		/// Failed Password Attempts
		///</summary>
		[ImplementPropertyType("umbracoMemberFailedPasswordAttempts")]
		public string UmbracoMemberFailedPasswordAttempts
		{
			get { return this.GetPropertyValue<string>("umbracoMemberFailedPasswordAttempts"); }
		}

		///<summary>
		/// Last Lockout Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLockoutDate")]
		public string UmbracoMemberLastLockoutDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLockoutDate"); }
		}

		///<summary>
		/// Last Login Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLogin")]
		public string UmbracoMemberLastLogin
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLogin"); }
		}

		///<summary>
		/// Last Password Change Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastPasswordChangeDate")]
		public string UmbracoMemberLastPasswordChangeDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastPasswordChangeDate"); }
		}

		///<summary>
		/// Is Locked Out
		///</summary>
		[ImplementPropertyType("umbracoMemberLockedOut")]
		public bool UmbracoMemberLockedOut
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberLockedOut"); }
		}

		///<summary>
		/// Password Answer
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalAnswer")]
		public string UmbracoMemberPasswordRetrievalAnswer
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalAnswer"); }
		}

		///<summary>
		/// Password Question
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalQuestion")]
		public string UmbracoMemberPasswordRetrievalQuestion
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalQuestion"); }
		}
	}

}
