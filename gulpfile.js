var gulp = require('gulp');

gulp.task("move-node-modules", function() {
    gulp.src([
            'core-js/client/shim.min.js',
            'systemjs/dist/system-polyfills.js',
            'systemjs/dist/system.src.js',
            'reflect-metadata/Reflect.js',
            'rxjs/**',
            'zone.js/dist/**',
            '@angular/**'
        ], 
        {
            cwd: "node_modules/**"
        })
        .pipe(gulp.dest("./wwwroot/libs"));
});

gulp.task('default', []);