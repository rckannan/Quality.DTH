using System;

namespace Quality.DTH
{
    public abstract class Entity
    {
        Int32? _requestedHashCode;
        Int64 _Idbase;
        public virtual Int64 Idbase
        {
            get
            {
                return _Idbase;
            }
            protected set
            {
                _Idbase = value;
            }
        } 
        public bool IsTransient()
        {
            return this.Idbase == default(Int64);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Entity))
                return false;

            if (Object.ReferenceEquals(this, obj))
                return true;

            if (this.GetType() != obj.GetType())
                return false;

            Entity item = (Entity)obj;

            if (item.IsTransient() || this.IsTransient())
                return false;
            else
                return item.Idbase == this.Idbase;
        }

        public override int GetHashCode()
        {
            if (!IsTransient())
            {
                if (!_requestedHashCode.HasValue)
                    _requestedHashCode = this.Idbase.GetHashCode() ^ 31;  
                return _requestedHashCode.Value;
            }
            else
                return base.GetHashCode();

        }
        public static bool operator ==(Entity left, Entity right)
        {
            if (Object.Equals(left, null))
                return (Object.Equals(right, null)) ? true : false;
            else
                return left.Equals(right);
        }

        public static bool operator !=(Entity left, Entity right)
        {
            return !(left == right);
        }
    }
}