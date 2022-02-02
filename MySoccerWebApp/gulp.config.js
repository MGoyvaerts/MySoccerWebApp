module.exports = {
    browserSync: {
      files: [
        "./Templates/public/assets/js/*.js",
        "./Templates/public/assets/css/*.css",
        "./Templates/public/**/*.html"
      ],
      server: {
        baseDir: "./Templates/public"
      },
      startPath: "index.html"
    },
    clean: {
      force: true
    },
    cleanRevision: {
      src: [
        "./Content/Custom/css",
        "./Content/Custom/js"
      ]
    },
    copyCSS: {
        src: "./Templates/public/assets/css/*.css",
        dest: "./Content/Custom/css/"
    },
    copyFonts: {
      src: "./Templates/public/assets/fonts/*",
      dest: "./Content/Custom/fonts"
    },
    copyImages: {
      src: "./Templates/public/assets/images/**/*",
      dest: "./Content/Custom/images"
    },
    copyScripts: {
      src: "./Templates/src/assets/js/*",
      dest: "./Content/Custom/js"
    },
    copy: {
      src: [
        "./Templates/public/assets/**/*.min.*",
        "./Templates/public/assets/**/*.woff2",
        "!./Templates/public/assets/media{,/**,/**/*.*}"
      ],
      dest: "./Content/assets"
    },
    html: {
      src: "./Templates/src/*.html",
      htmlmin: {
        // In case more html file operations are needed.
        opts: {
          // https://github.com/kangax/html-minifier
          collapseWhitespace: true,
          removeComments: true
        }
      },
      dest: "./Templates/public"
    },
    images: {
      src: "./Templates/src/assets/images/**/*.{png,jpg,jpeg,gif,svg}",
      dest: "./Templates/public/assets/images"
    },
    fonts: {
      src: ["./Templates/src/assets/fonts/*.*"],
      dest: "./Templates/public/assets/fonts"
    },
    rename: {
      min: { suffix: ".min" }
    },
    sass: {
      src: [
        "./Templates/src/assets/scss/**/*.{sass,scss}"
      ],
      dest: "./Templates/public/assets/css",
      imagePath: "/assets/images",
      minify: false
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
      dest: "./Templates/public/assets/js",
      file: "scripts.js",
      minify: false
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
    revisionCSS: {
      src: "./Templates/public/assets/css/*.{css,js}",
      dest: "./Content/Custom/css/"
    }
  };