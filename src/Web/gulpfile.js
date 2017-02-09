/// <binding AfterBuild='min:js, min:css, min:cssAll, cat:jsAll' />
/*
This file in the main entry point for defining Gulp tasks and using Gulp plugins.
Click here to learn more. http://go.microsoft.com/fwlink/?LinkId=518007
*/

//https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Strict_mode
"use strict";

var gulp = require('gulp'),
    //https://docs.microsoft.com/en-us/aspnet/core/client-side/bundling-and-minification
    concat = require('gulp-concat'),
    cssmin = require('gulp-cssmin'),
    uglify = require('gulp-uglify'),
    //http://bguiz.github.io/js-standards/angularjs/minification-and-annotation/
    ngAnnotate = require('gulp-ng-annotate');

var webroot = "./wwwroot/";
var paths = {
    //https://github.com/isaacs/node-glob
    js: webroot + "js/*.js",
    minJs: webroot + "js/**/*.min.js",
    modules: webroot + "js/modules/**/*.js",
    config: webroot + "js/config/**/*.js",
    controllers: webroot + "js/controllers/**/*.js",
    jQueryMin: webroot + "lib/jquery/dist/*.min.js",
    ignoreJQuerySlim: "!" + webroot + "lib/jquery/dist/*.slim.min.js",
    ngMin: webroot + "lib/angular/*.min.js",
    ngRoute: webroot + "lub/angular-rotue/*.min.js",
    bootstrapMinJs: webroot + "lib/bootstrap/dist/js/*.min.js",
    tinyMceMin: webroot + "lib/tinymce/tinymce.min.js",
    tinyMceJqueryMin: webroot + "lib/tinymce/jquery.tinymce.min.js",
    concatJsDest: webroot + "js/site.min.js",
    concatJsAll: webroot + "js/all.min.js",
    css: webroot + "css/**/*.css",
    minCss: webroot + "css/**/*.min.css",
    bootstrapMinCss: webroot + "lib/bootstrap/dist/css/*.min.css",
    fontAwesomeMin: webroot + "lib/font-awesome/css/*.min.css",
    concatCssDest: webroot + "css/site.min.css",
    concatCssAll: webroot + "css/all.min.css"
}

gulp.task('min:js', function () {
    return gulp.src([paths.js, "!" + paths.minJs])
        .pipe(concat(paths.concatJsDest))
        .pipe(ngAnnotate())
        .pipe(uglify())
        .pipe(gulp.dest("."));
});

gulp.task('cat:jsAll', ['min:js'], function () {
    return gulp.src([paths.jQueryMin, paths.ignoreJQuerySlim,
            paths.ngMin, paths.ngRoute,
            paths.bootstrapMinJs, paths.tinyMceMin, paths.tinyMceJqueryMin,
            paths.modules, paths.config, paths.controllers])
        .pipe(concat(paths.concatJsAll))
        .pipe(gulp.dest("."));
});

gulp.task('min:css', function () {
    return gulp.src([paths.css, "!" + paths.minCss])
        .pipe(concat(paths.concatCssDest))
        .pipe(cssmin())
        .pipe(gulp.dest("."));
});

gulp.task('min:cssAll', ['min:css'], function () {
    return gulp.src([paths.bootstrapMinCss, paths.fontAwesomeMin])
        .pipe(concat(paths.concatCssAll))
        .pipe(gulp.dest("."));
});