// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using AppKit;
using C1.Mac.CollectionView;

namespace C1CollectionView101
{
	public partial class OnDemandViewController : NSViewController
	{
        private YouTubeCollectionView _collectionView;

        public OnDemandViewController (IntPtr handle) : base (handle)
		{
		}

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            SearchField.Changed += OnSearchChanged;

            _collectionView = new YouTubeCollectionView();
            var source = new C1TableViewSource(TableView);
            source.ItemsSource = _collectionView;
            TableView.Source = source;
        }

        private async void OnSearchChanged(object sender, EventArgs e)
        {
            await _collectionView.SearchAsync(SearchField.StringValue);
        }
    }
}