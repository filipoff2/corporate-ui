var gulp = require("gulp"),
    fs = require("fs"),
    less = require("gulp-less");


gulp.task("Build Less File", function () {
    return gulp.src('MainPage.less')
        .pipe(less())
        .pipe(gulp.dest('../StyleGuide/Styles'));
});



gulp.task('default', ['Build Less File']); 