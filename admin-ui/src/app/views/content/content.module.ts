import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';

import { ChartjsModule } from '@coreui/angular-chartjs';
import { IconModule } from '@coreui/icons-angular';
import { AutoCompleteModule } from 'primeng/autocomplete';
import { BadgeModule } from 'primeng/badge';
import { BlockUIModule } from 'primeng/blockui';
import { ButtonModule } from 'primeng/button';
import { CheckboxModule } from 'primeng/checkbox';
import { DropdownModule } from 'primeng/dropdown';
import { DynamicDialogModule } from 'primeng/dynamicdialog';
import { EditorModule } from 'primeng/editor';
import { ImageModule } from 'primeng/image';
import { InputNumberModule } from 'primeng/inputnumber';
import { InputTextModule } from 'primeng/inputtext';
import { InputTextareaModule } from 'primeng/inputtextarea';
import { KeyFilterModule } from 'primeng/keyfilter';
import { PaginatorModule } from 'primeng/paginator';
import { PanelModule } from 'primeng/panel';
import { ProgressSpinnerModule } from 'primeng/progressspinner';
import { TableModule } from 'primeng/table';
import { ExtSharedModule } from 'src/app/shared/modules/ext-shared.module';
import { ContentRoutingModule } from './content-routing.module';
import { PostCategoryDetailComponent } from './post-categories/post-category-detail/post-category-detail.component';
import { PostCategoryComponent } from './post-categories/post-category.component';
import { PostActivityLogsComponent } from './posts/post-activity-logs/post-activity-logs.component';
import { PostDetailComponent } from './posts/post-detail/post-detail.component';
import { PostReturnReasonComponent } from './posts/post-return-reason/post-return-reason.component';
import { PostSeriesComponent } from './posts/post-series/post-series.component';
import { PostComponent } from './posts/post.component';
import { SeriesDetailComponent } from './series/series-detail/series-detail.component';
import { SeriesPostsComponent } from './series/series-posts/series-posts.component';
import { SeriesComponent } from './series/series.component';

@NgModule({
  imports: [
    ContentRoutingModule,
    IconModule,
    CommonModule,
    ReactiveFormsModule,
    ChartjsModule,
    ProgressSpinnerModule,
    PanelModule,
    BlockUIModule,
    PaginatorModule,
    BadgeModule,
    CheckboxModule,
    TableModule,
    KeyFilterModule,
    ExtSharedModule,
    ButtonModule,
    InputTextModule,
    InputTextareaModule,
    DropdownModule,
    EditorModule,
    InputNumberModule,
    ImageModule,
    AutoCompleteModule,
    DynamicDialogModule
  ],
  declarations: [PostComponent, PostCategoryComponent, PostCategoryDetailComponent, PostActivityLogsComponent, PostDetailComponent, PostReturnReasonComponent, PostSeriesComponent, SeriesComponent, SeriesPostsComponent, SeriesDetailComponent],
})
export class ContentModule {}
