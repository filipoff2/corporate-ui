var gulp = require("gulp"),
    less = require("gulp-less");

var cssOutPutFolder = "../StyleGuide/StyleGuide/Styles";

gulp.task("less", function () {
    return gulp.src("*.less")
        .pipe(less())
        .pipe(gulp.dest(cssOutPutFolder));
});


gulp.task('default', gulp.series(['less'])); 