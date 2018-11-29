namespace ComicBookGallery.Models
{
    public class ComicBook
    {
        private int Id { get; set; }
        private string SeriesTitle { get; set; }
        private int IssueNumber { get; set; }
        private string DescriptionHTML { get; set; }
        private Artist[] Artists { get; set; }
        private bool Favorite { get; set; }
        public string DisplayText => SeriesTitle + " #" + IssueNumber;

        public string CoverImageFileName => SeriesTitle.Replace(" ", "-")
                                                .ToLower() + "-" + IssueNumber + ".jpg";
    }
}