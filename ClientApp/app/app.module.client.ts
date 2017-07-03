import { NgModule } from '@angular/core';
import { sharedConfig } from './app.module.shared';

@NgModule({
    bootstrap: sharedConfig.bootstrap,
    declarations: sharedConfig.declarations,
    imports: [
        
        ...sharedConfig.imports
    ],
    providers: [
		{ provide: 'ORIGIN_URL', useValue: location.origin },
		...sharedConfig.providers
    ]
})
export class AppModule {
}
