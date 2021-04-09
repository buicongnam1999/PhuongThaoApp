<template>
    <div class="navbar-icon">
        <li>
            <router-link v-bind="$attrs">
                <slot name="sidebar-icon"></slot>
                <div class="navbar-text">
                    <slot></slot>
                </div>
            </router-link>
        </li>
    </div>
</template>
<script>
export default {
    inheritAttrs: false,
}
</script>
<style scoped>
.navbar-icon a{
    list-style: none;
    text-decoration: none;
    width: 100%;
    display: flex;
    line-height: 50px;
    color: black;
}
.navbar-icon a:hover{
    background: #e5e5ee;
}
.navbar-text{
    font-size: 13px;
}

</style>