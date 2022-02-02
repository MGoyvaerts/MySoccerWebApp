/*=================Declarations=================*/

var gulp = require("gulp"),
    autoprefixer = require("autoprefixer"),
    browserSync = require("browser-sync").create(),
    concat = require("gulp-concat"),
    cssnano = require("cssnano"),
    csso = require("gulp-csso"),
    minifyCss = require("gulp-minify-css"),
    nunjucksRender = require("gulp-nunjucks-render"),
    postcss = require("gulp-postcss"),
    rename = require("gulp-rename"),
    sass = require('gulp-sass')(require('sass')),
    sourcemaps = require("gulp-sourcemaps"),
    uglify = require("gulp-uglify");


var paths = {
    styles: {
        // By using styles/**/*.sass we're telling gulp to check all folders for any sass file
        src: "./Templates/src/assets/scss/**/*.{sass,scss}",
        // Compiled files will end up in whichever folder it's found in (partials are not compiled)
        dest: "./Templates/public/assets/css"
    },
    sass: {
        src: [
            "./Templates/src/assets/scss/**/*.{sass,scss}"
        ],
        dest: "./Templates/public/assets/css"
    },
    scripts: {
        src: [
            "./node_modules/jquery/dist/jquery.js",
            "./node_modules/jquery-match-height/dist/jquery.matchHeight.js",
            "./node_modules/jquery-ajax-unobtrusive/dist/jquery.unobtrusive-ajax.js",
            "./node_modules/bootstrap/dist/js/bootstrap.js",
            "./node_modules/owl.carousel/dist/owl.carousel.js",
            "./node_modules/simple-lightbox/dist/simpleLightbox.js",
            "./Templates/src/assets/js/**/*.js"
        ],
        dest: "./Templates/public/assets/js"
    },
    nunjucks: {
        src: ["pages/**/*.nunjucks", "templates/**/*.nunjucks"],
        pagePath: "./Templates/src/pages/",
        templatePath: "./Templates/src/templates",
        dest: "./Templates/public/",
        envOptions: {
            watch: true
        }
    },
    rename: {
        min: { suffix: ".min" }
    },
    browserSync: {
        server: {
            baseDir: "./Templates/public"
        },
        startPath: "index.html"
    },
    images:{
        src: "./Templates/src/assets/images/**/*",
        dest: "./Templates/public/assets/images"
    }
};

/*=================End declarations=================*/

/*=================Functions=================*/

// A simple task to reload the page
function reload() {
    browserSync.reload();
}

function watch() {
    browserSync.init({
        server: {
            baseDir: paths.browserSync.server.baseDir
        }
        // If you are already serving your website locally using something like apache
        // You can use the proxy setting to proxy that instead
        // proxy: "yourlocal.dev"
    });
    gulp.watch(paths.nunjucks.src, nunjucks);
    gulp.watch(paths.styles.src, styles);
    gulp.watch(paths.scripts.src, scripts);
    gulp.watch(paths.images.src, images);
    // We should tell gulp which files to watch to trigger the reload
    // This can be html or whatever you're using to develop your website
    // Note -- you can obviously add the path to the Paths object
    gulp.watch(paths.browserSync.server.baseDir + "/*")
        .on("change", reload);
}

function nunjucks() {
    return gulp
        .src("./Templates/src/pages/**/*.+(html|nunjucks)")
        .pipe(
            nunjucksRender({
                path: [paths.nunjucks.pagePath, paths.nunjucks.templatePath] // String or Array
            })
        )
        .pipe(gulp.dest(paths.nunjucks.dest));
}

function styles() {
    return gulp
        .src(paths.sass.src)
        .pipe(concat("styles.css"))
        .pipe(sass().on("error", sass.logError))
        .pipe(csso())
        .pipe(rename(paths.rename.min))
        .pipe(gulp.dest(paths.sass.dest))
        .pipe(browserSync.stream());
}

function sass() {
    return gulp
        .src(paths.sass.src)
        .pipe(concat("styles.css"))
        .pipe(sass().on("error", sass.logError))
        .pipe(csso())
        .pipe(gulp.dest(paths.sass.dest))
        .pipe(browserSync.stream());
}

function scripts() {
    return gulp
        .src(paths.scripts.src)
        .pipe(concat("scripts.js"))
        .pipe(uglify())
        .pipe(rename(paths.rename.min))
        .pipe(gulp.dest(paths.scripts.dest))
        .pipe(browserSync.stream());
}

function images(){
    return gulp
        .src(paths.images.src)
        .pipe(gulp.dest(paths.images.dest))
        .pipe(browserSync.stream());
}

/*=================End functions=================*/


/*=================Build tasks=================*/


// We don't have to expose the reload function
// It's currently only useful in other functions


// Don't forget to expose the task!
exports.watch = watch

// Expose the task by exporting it
// This allows you to run it from the commandline using
// $ gulp style
exports.nunjucks = nunjucks;
exports.styles = styles;
exports.scripts = scripts;
exports.images = images;

/*
 * Specify if tasks run in series or parallel using `gulp.series` and `gulp.parallel`
 */
var build = gulp.parallel(nunjucks, styles, scripts, images);

/*
 * You can still use `gulp.task` to expose tasks
 */
//gulp.task('build', build);

/*
 * Define default task that can be called by just running `gulp` from cli
 */
gulp.task('default', gulp.parallel(build, watch));
gulp.task('build', build);

/*=================End build tasks=================*/