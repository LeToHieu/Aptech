﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PhotoSharingApplication.Models
{
    public class PhotoSharingContext : DbContext, IPhotoSharingContext
    {
        public PhotoSharingContext() : base()
        {
            this.Database.CommandTimeout = 180;
        }

        public DbSet<Photo> Photos { get; set; }
        public DbSet<Comment> Comments { get; set; }
        IQueryable<Photo> IPhotoSharingContext.Photos
        {
            get { return Photos; }
        }
        IQueryable<Comment> IPhotoSharingContext.Comments
        {
            get { return Comments; }
        }
        int IPhotoSharingContext.SaveChanges()
        {
            return this.SaveChanges();
        }
        T IPhotoSharingContext.Add<T>(T entity)
        {
            return Set<T>().Add(entity);
        }
        Photo IPhotoSharingContext.FindPhotoById(int ID)
        {
            return Set<Photo>().Find(ID);
        }
        Comment IPhotoSharingContext.FindCommentById(int ID)
        {
            return Set<Comment>().Find(ID);
        }
        T IPhotoSharingContext.Delete<T>(T entity)
        {
            return Set<T>().Remove(entity);
        }
    }
}